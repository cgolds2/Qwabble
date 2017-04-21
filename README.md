# groupProject01:Qwabble
Created by:<br>
Connor Goldsmith<br>
Sarah Sicard<br>
Ryan Smith<br>
Caroline Jarecke<br>

This project is designed to be a multi-platform mobile app that works as a tool to organize activites and duties in apartments. 
We will be using Xamarin in order to devleop this app.

This project is for CSC 3380, Object Oriented Design at Louisiana State University. 

# Compiling Qwabble
Qwabble is made using [Visual Studios](https://www.visualstudio.com/) with [Xamarin](https://www.xamarin.com/)
<br><br>  --STEPS--
1. Download Visual Studios 15
2. When installing, select the cross-platform option
<br>   note: More info on this can be found [here](https://msdn.microsoft.com/en-us/library/mt613162.aspx)
3. Download the Source Code
4. Some builds of VS might install a different version of Xamarin.  Right click the project and select "Manage NuGet Packages", and there might be an option to install/restore the correct version
5. Build the solution.  

# Build Guide 
If using the VS simulator, use the groupProject01.Droid Project<br>
If using iPhone/Mac, see [here](https://developer.xamarin.com/guides/ios/getting_started/installation/mac/)

# Building the Database
The database is located [in another repository that can be found here](https://github.com/dalaylan/3380-group-project-server-code)<br>
1. Follow the instructions in the README.txt to build the database
2. Go to the file [groupProject01/Settings/ServerHandeler.cs](https://github.com/cgolds2/groupProject01/blob/master/groupProject01/groupProject01/Settings/ServerHandeler.cs)
3. Change the "baseuri" string to point to your server on your local network
