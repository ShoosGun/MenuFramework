﻿using UnityEngine;
using UnityEngine.UI;

namespace MenuFramework
{
	public class MenuAPI
	{
		// TITLE SCREEN
		public GameObject TitleScreen_MakeMenuOpenButton(string name, Menu menuToOpen)
			=> TitleButtonManager.Instance.MakeMenuOpenButton(name, menuToOpen);

		public GameObject TitleScreen_MakeSceneLoadButton(string name, SubmitActionLoadScene.LoadableScenes sceneToLoad, PopupMenu confirmPopup = null)
			=> TitleButtonManager.Instance.MakeSceneLoadButton(name, sceneToLoad, confirmPopup);

		public Button TitleScreen_MakeSimpleButton(string name)
			=> TitleButtonManager.Instance.MakeSimpleButton(name);

		// PAUSE MENU
		public GameObject PauseMenu_MakeMenuOpenButton(string name, Menu menuToOpen, Menu customMenu = null)
			=> PauseButtonManager.Instance.MakeMenuOpenButton(name, menuToOpen, customMenu);

		public GameObject PauseMenu_MakeSceneLoadButton(string name, SubmitActionLoadScene.LoadableScenes sceneToLoad, PopupMenu confirmPopup = null, Menu customMenu = null)
			=> PauseButtonManager.Instance.MakeSceneLoadButton(name, sceneToLoad, confirmPopup, customMenu);

		public Button PauseMenu_MakeSimpleButton(string name, Menu customMenu = null)
			=> PauseButtonManager.Instance.MakeSimpleButton(name, customMenu);

		public Menu PauseMenu_MakePauseListMenu(string title)
			=> PauseButtonManager.Instance.MakePauseListMenu(title);

		// OPTIONS
		public Menu OptionsMenu_MakeNonScrollingOptionsTab(string name)
			=> OptionsMenuManager.Instance.MakeNonScrollingOptionsTab(name);

		// MISC
		public PopupMenu MakeTwoChoicePopup(string message, string confirmText, string cancelText)
			=> PopupMenuManager.Instance.CreateTwoChoicePopup(message, confirmText, cancelText);

		public PopupInputMenu MakeInputFieldPopup(string message, string placeholderMessage, string confirmText, string cancelText)
			=> PopupMenuManager.Instance.CreateInputFieldPopup(message, placeholderMessage, confirmText, cancelText);


	}
}
