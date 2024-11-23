//========= Copyright OpenMod, All rights reserved. ============//
//
// Purpose:
//
// $NoKeywords: $
//=============================================================================//

#include "cbase.h"
#include "basemenu.h"

#include "vgui/ILocalize.h"
#include "vgui/IPanel.h"
#include "vgui/ISurface.h"
#include "vgui/ISystem.h"
#include "vgui/IVGui.h"
#include "ienginevgui.h"
#include <engine/IEngineSound.h>
#include "filesystem.h"

// memdbgon must be the last include file in a .cpp file!!!
#include "tier0/memdbgon.h"

using namespace vgui;

static CDllDemandLoader g_GameUIDLL( "GameUI" );

RootPanel *guiroot = NULL;

void OverrideRootUI()
{
	if( !OverrideUI->GetPanel() )
	{
		OverrideUI->Create(NULL);
	}
	if( guiroot->GetGameUI() )
	{
		guiroot->GetGameUI()->SetMainMenuOverride( guiroot->GetVPanel() );
		return;
	}
}

RootPanel::RootPanel(VPANEL parent) : Panel( NULL, "RootPanel" )
{
	SetParent(parent);
	guiroot = this;

	m_bCopyFrameBuffer = false;
	gameui = NULL;

	LoadGameUI();

	m_ExitingFrameCount = 0;

    m_pHTMLPanel = new vgui::HTML(this, "HTMLPanel");
    m_pHTMLPanel->SetScrollbarsEnabled(false);
	m_pHTMLPanel->SetContextMenuEnabled(false);
	m_pHTMLPanel->SetViewSourceEnabled(false);
#if 0
	m_pHTMLPanel->RunJavascript(
		"document.body.style.userSelect = 'none';"
		"document.body.style.webkitUserSelect = 'none';"
		"document.body.style.mozUserSelect = 'none';"
		"document.body.style.msUserSelect = 'none';"
		"document.body.style.touchAction = 'none';"
	);
	// oh well..
#endif
}

IGameUI *RootPanel::GetGameUI()
{
	if( !gameui )
	{
		if ( !LoadGameUI() )
			return NULL;
	}

	return gameui;
}

bool RootPanel::LoadGameUI()
{
	if( !gameui )
	{
		CreateInterfaceFn gameUIFactory = g_GameUIDLL.GetFactory();
		if ( gameUIFactory )
		{
			gameui = (IGameUI *) gameUIFactory(GAMEUI_INTERFACE_VERSION, NULL);
			if( !gameui )
			{
				return false;
			}
		}
		else
		{
			return false;
		}
	}
	return true;
}

RootPanel::~RootPanel()
{
	gameui = NULL;
	g_GameUIDLL.Unload();
}

void RootPanel::ApplySchemeSettings(IScheme *pScheme)
{
	BaseClass::ApplySchemeSettings(pScheme);

	// Resize the panel to the screen size
	// Otherwise, it'll just be in a little corner
	int wide, tall;
	vgui::surface()->GetScreenSize(wide, tall);
	SetSize(wide,tall);

    const char *gameDir = engine->GetGameDirectory();
    char filePath[256];
    sprintf( filePath, "%s/html/menu.html", gameDir );

    m_pHTMLPanel->SetBounds(0, 0, wide, tall);
    m_pHTMLPanel->OpenURL(filePath, nullptr, true);
}

class COverrideInterface : public IOverrideInterface
{
private:
	RootPanel *MainMenu;
 
public:
	int UI_Interface( void )
	{
		MainMenu = NULL;
	}
 
	void Create( vgui::VPANEL parent )
	{
		MainMenu = new RootPanel(parent);
	}

	vgui::VPANEL GetPanel( void )
	{
		if ( !MainMenu )
			return NULL;
		return MainMenu->GetVPanel();
	}
 
	void Destroy( void )
	{
		if ( MainMenu )
		{
			MainMenu->SetParent( (vgui::Panel *)NULL );
			delete MainMenu;
		}
	}
 
    virtual RootPanel* GetMenuBase() override
    {
        return MainMenu;
    }
};
 
static COverrideInterface g_SMenu;
IOverrideInterface *OverrideUI = ( IOverrideInterface * )&g_SMenu;