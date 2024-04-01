**Purpose**
Users can create a single environment to track multiple kinds of chores including daily, single-use, and weekly. Information for each child is password protected.
_Information stored_
Name, age, password, current points are stored for each user. Future use: bool if user is logged in.
Each chore has name, value in points, if it is complete, and a timestamp for when chore was created. Each renewable task has DateTime for when it is to be renewed (daily or weekly).
Has multiple savepoints throughout to save new information.

**Encapsulation**
All classes have private attributes and uses OOP. Data stays with each object.

**Inheritance**
Each child (primary, elementary, middle, high) inherits from the Child class. 
Each chore inherits from the Task class. 

**Polymorphism**
_separated by age_
Upon creation, each user is determined by the child's age. The range the child's age is in creates an appropriate user level for them.
_password requirements_
Requirements when creating new password get more advanced for each ascending age group.
_strings saved in file for users/tasks_
There are different ways a task can be saved in the file for storage.
_display_
Some tasks display differently.
_set frequency_
The different tasks are renewed at different times.
_separated by task_
A specific type of task is created depending upon user choice


**User Experience**
**startup**
Menu displays with login or create new user options.

_create new user_
-prompts for birthday
-determines age and creates user
-prompts for name and password
-returns to login/new user menu.

_login_
-list of current users is listed.
-user inserts number correlating to user.
-password prompt appears with validation.
-menu appears with user's abilities

_user abilities_
-add new task
-records task complete
-lists user's tasks
-change password
-logout

_end_
program ends when users log out and select Quit.

**Resources**
I used various resources to help with topics such as DateTime and Regex. 
_https://stackoverflow.com/questions/32222646/regex-to-allow-some-special-characters-c-sharp_
_https://www.c-sharpcorner.com/article/datetime-in-c-sharp/_
_https://www.c-sharpcorner.com/blogs/timespan-in-c-sharp_