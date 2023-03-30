# ActivityLog Application

## Description
This is an application that is used to keep track of daily activities done during the day.  I based it off of the activity reports we do at the South Texas College Open labs. 

![database](https://user-images.githubusercontent.com/128923702/228880535-f1fb3ba6-304a-479a-ab6c-9e0672ac68f8.png)

I used the ASP.NET and Entity framework to build this application.  Which consists of at least 4 different languages.  The reason I went with that framework was because it was very user friendly.  It was also easier for me to understand as someone who doesn't have a lot of experience using frameworks.  There was also a lot of educational material that was readily available.  I attempted to use the Django Rest API framework that is built on Python, but after messing with both of them a while I decided to use ASP.NET.  There is still a lot for me to learn about this tool, but it was fun to do the research and create the application.  I liked using Microsoft Edge with this application.  Firefox worked well but on the initial setup it will ask you to accept the risk and continue.  In addition, the time created feature works a little better on Edge.

There were a few issues I ran into.  I had hard time creating some of the controllers, because of errors I would receive when the Entity framework was generating some of the code.  I resolved this by fixing some ambiguously declared variables.  Then I had an issue where I couldn’t get the data entries to sort by the time.  For some reason “await” doesn’t play nicely with some of the display methods.  But once I removed that I was able to use “OrderByDecending” with no issue.  Then I had an issue with the footer on the webpage layout.  It would stay in the same spot and would overlap as my main section of the webpage grew.  So, I had to find the footer section and remove the position option.      

There are a few things I would like to change in the future.  The first is that I would like to have each entry tied to user that input it.  It would also be cool to add a search feature in the future.  Another improvement I would like to implement would be “Supervisor Accounts”.  That way a supervisor could like or respond to the entries made.  I would also like to fix a small issue that occurs when creating and verifying an account.  The user has to sign in again immediately after creating an account, and it’s kind of annoying.  I know a lot of websites do this, but I don’t like it. 

## How to Install
Visual Studios 2022 should be installed.
Open Visual Studios 2022 and select clone repository.
![selectclone](https://user-images.githubusercontent.com/128923702/228883631-dcbf3f45-dcbd-439d-8f54-f4009a787bf2.png)
Then input the repository location which is https://github.com/cherre31/ActivityLog.git then you can select the file path and press clone.
![howtoclone](https://user-images.githubusercontent.com/128923702/228883677-916efe65-8ba8-445a-a379-c9935277c890.png)
From here you can run it by clicking the https run button.
![pressthehttpsrunbutton](https://user-images.githubusercontent.com/128923702/228884068-eca4a3d5-25b9-4a42-aa5b-9dfc8a0f0776.png)
After pressing the run button you will be prompted to trust a certificate.  Press yes to trust it.
![trustcertifcate](https://user-images.githubusercontent.com/128923702/228893228-53775e51-1c35-4bcf-b495-746517d66c56.png)
Then you will be prompted to install the certificate.  Press yes to install it.   
![installcertificate](https://user-images.githubusercontent.com/128923702/228893266-0d0bcdd6-7bf2-4c4b-835b-3af61857b74c.png)

You may have to repeat that process. 

After everything as been trusted the homepage will be brought up.  You can click on the activities tab to complete the installation.
![Homepage](https://user-images.githubusercontent.com/128923702/228894308-eb06cc4d-96e5-4a34-97c8-f03e4a6d9f26.png)
Once the activities tab is opened you should see an error message.  This is because the database have not been created.  Click on Apply Migrations to have them generated.
![failedtoopendatabase](https://user-images.githubusercontent.com/128923702/228886381-bf90d710-5112-4d5a-b734-e3f5eadc5a0e.png)
Refresh the page to view the updated activities tab, and installation is complete. 
![databasenowavailable](https://user-images.githubusercontent.com/128923702/228886422-442efeba-53c5-4f17-9f9d-5ea957f447e7.png)

## How to Use

