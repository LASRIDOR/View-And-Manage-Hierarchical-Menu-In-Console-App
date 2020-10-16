# View And Manage Hierarchical Menu In Console App

# Goals
• Object-oriented programming and polymorphism
• Implementation of work with interfaces
• Implementation of work with voters for functions and delegations (delegates)

# Knowledge required
• Working with interfaces
• Working with delegations - delegates
• Collections in use
• Working with several projects

# The exercise
implement a department that assists in the presentation and management of hierarchical menus for applications Console.
This department should allow (the program it will use) to build a menu according to its needs by defining menu items in the main menu or for each submenu.
This class should be called MainMenu.
An app that wants to display menus to the user must hold a MainMenu class instance.
The MainMenu class will allow its user (for example the programmer who builds the garage app) to build the menu hierarchy (say in the initialization stage of his app) by defining and adding menu items (MenuItem) to the menu and sub-items for each item and so on.
As an example of a menu with menu items built in a hierarchical way, take for example the menu of studio visual - the main menu is at the top of the window and contains several items at the first level ... View, Edit, File, which contain items themselves. Clicking on some of the items causes some action in the software. Clicking on other items causes a sub-menu to appear (additional menu items grouped under the item we selected) and so on.

# Characterization
As mentioned, you need to implement a software component that provides display and management of hierarchical menus for Console applications.
Enabling the m_MainMenu.Show () function will display the main menu (first level) and will actually hold the loop that will actually be the main loop that each console application needs to exist.
At each stage:
1. The current level of the user menu will be displayed
2. A request will be displayed for the user to select one of the items.
3. Record the selection from the user
4. Input integrity check will be performed + an appropriate message will be displayed in case of incorrect input
5. Sub-menu navigation / Activating the selected action:
A. Selecting an item that contains sub-items will clear the screen and display the sub-items Relevant (i.e. the next level in the menu, i.e. back to section 1.
B. Choosing an item that does not contain sub-items, i.e. it is a choice for which to happen Any action in the system (for example - the possibility of putting a new vehicle in the garage) will clear the
Screen and activate the function in the system that provides the user interface that supports this functionality of the system. After completing the operation in the system, the level of the menu where we were before will be displayed again and will repeat until the moment the user is selected In the option to exit the program (by a special item in the menu)
Please note: the menu regularly displays in this order (at any level :)

Title (first level - main title, at any other level - the title of the item selected at the previous level)
- List of items belonging to the current level (numbered from 1)
- Item that says 'Back' (or 'Exit' if that is the main menu) (numbered from 0)
- A message asking the user to select from the items or select the item 'Back' / 'Exit'

# More explanations for those who did not understand
The component allows those who use it (another programmer) to build a menu according to their needs, with submenus accordingly, and use it instead of implementing the menu for the user himself.
The way to do this is by having the component hold a collection of menu items, and each item will hold a collection of sub-items if necessary (which will constitute its sub-menu) and so on.
A system that uses this menu mechanism (for example, a garage management system) should have a function that initializes its menu structure.
Regarding the functions that the final items (the "leaves)" must activate - there should indeed be a way to allow them to activate the appropriate function in the application (final item = an item that has no sub-items, ie an item that aims to activate a particular action and not display a sub-menu.)
