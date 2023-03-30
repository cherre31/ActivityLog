# ActivityLog Application

## Description
This is an application that is used to keep track of daily activities done during the day.  I based it off of the activity reports we do at the South Texas College Open labs. 

![database](https://user-images.githubusercontent.com/128923702/228880535-f1fb3ba6-304a-479a-ab6c-9e0672ac68f8.png)

I used the ASP.NET and Entity framework to build this application.  Which consists of at least 4 different languages.  The reason I went with that framework was because it was very user friendly.  It was also easier for me to understand as someone who doesn't have a lot of experience using frameworks.  There was also a lot of educational material that was readily available.  I attempted to use the Django Rest API framework that is built on Python, but after messing with both of them a while I decided to use ASP.NET.  There is still a lot for me to learn about this tool, but it was fun to do the research and create the application.  

There were a few issues I ran into.  I had hard time creating some of the controllers, because of errors I would receive when the Entity framework was generating some of the code.  I resolved this by fixing some ambiguously declared variables.  Then I had an issue where I couldn’t get the data entries to sort by the time.  For some reason “await” doesn’t play nicely with some of the display methods.  But once I removed that I was able to use “OrderByDecending” with no issue.  Then I had an issue with the footer on the webpage layout.  It would stay in the same spot and would overlap as my main section of the webpage grew.  So, I had to find the footer section and remove the position option.      

There are a few things I would like to change in the future.  The first is that I would like to have each entry tied to user that input it.  It would also be cool to add a search feature in the future.  Another improvement I would like to implement would be “Supervisor Accounts”.  That way a supervisor could like or respond to the entries made.  I would also like to fix a small issue that occurs when creating and verifying an account.  The user has to sign in again immediately after creating an account, and it’s kind of annoying.  I know a lot of websites do this, but I don’t like it. 

## How to Install
The installation of this program should be fairly straightforward.  Simply clone the GitHub repository in Visual Studios 2022 and it should run fairly simply with http, https, or IIS.  I attempted to use it with older versions of Visual Studios like VS 2019, but it didn’t work with them since the .net version I am using is .net7 which is the latest.  There is the option to use an empty database or a populated one.  If you’d like to use an empty one just run the program and navigate to the Activities tab.  From there it will tell you that it failed to login to the database.  
