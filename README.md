# ActivityLog Application

## Description
This is an application that is used to keep track of daily activities done during the day.  I based it off of the activity reports we do at the South Texas College Open labs. 

![populateddatabase](https://user-images.githubusercontent.com/128923702/228906362-0528e152-2c43-497e-a4c4-de93780ce9fe.png)

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

After everything as been trusted the homepage will be brought up.  Some browsers may ask you to accept the risk to continue others may not.  You can click on the activities tab to complete the installation.

![Homepage](https://user-images.githubusercontent.com/128923702/228894308-eb06cc4d-96e5-4a34-97c8-f03e4a6d9f26.png)

Once the activities page is opened you should see an error message.  This is because the database have not been created.  Click on Apply Migrations to have them generated.

![failedtoopendatabase](https://user-images.githubusercontent.com/128923702/228886381-bf90d710-5112-4d5a-b734-e3f5eadc5a0e.png)

Refresh the page to view the updated activities page, and installation is complete. 

![databasenowavailable](https://user-images.githubusercontent.com/128923702/228886422-442efeba-53c5-4f17-9f9d-5ea957f447e7.png)

## How to Use
After everything has been installed you can go about using the web application normally.
From the homepage you can see several tabs.

![Homepage](https://user-images.githubusercontent.com/128923702/228898654-829e0e65-09e5-4a61-ada1-f5fa7949349f.png)

If you navigate to the Activities page you can see the option to Create a new data entry.  

![databasenowavailable](https://user-images.githubusercontent.com/128923702/228903419-42e036b2-d495-48cc-b91e-94d04b998fe9.png)

Clicking on it will prompt you to sign in.  But since this is a fresh install there are no users stored in the database. 

![emptylogin](https://user-images.githubusercontent.com/128923702/228903684-bf51d560-64ce-4f77-a302-382da01e9984.png)

So, we can click on the link that says Register as a new user.

![registrationpage](https://user-images.githubusercontent.com/128923702/228903726-13bbb894-d2de-4637-a3d2-69383bf13b61.png)

After inputting the requested information and selecting the Register button we will be met with a Register Confirmation page.  Normally you would receive an email.  But we can just click the link that says Click here to confirm your account.

![regconfirm](https://user-images.githubusercontent.com/128923702/228903776-5cdda0f7-798e-4a23-a82e-58fbaec2ac58.png)
![confirmed](https://user-images.githubusercontent.com/128923702/228903797-8213250c-e0af-4155-ba0d-5196e807a01d.png)

We will have to sign in again in just a moment.  As we navigate back to the Activities page.  We can select Create and sign in this time with the account we just created.  After signing we will see the Create page.  We can input the data and hit create.

![loginpage](https://user-images.githubusercontent.com/128923702/228903912-0b8cdc5c-a9cc-459f-bb5f-b12ef0a22f92.png)
![createtab](https://user-images.githubusercontent.com/128923702/228903931-b43de743-62f6-4fbd-9c69-d731e77fc7af.png)

We will be brought back to the activities page and your entry will now be listed in a table.  From here you can create a new post or make changes to the post that have already been made.  

![populateddatabase](https://user-images.githubusercontent.com/128923702/228904374-12baba2d-a4f5-4e4a-a828-eeacd7e80d18.png)

Let’s edit a post.  We will click on the edit link next to one of the entries in the table.  From here we can edit any part of the entry.  When we are done, we can save it.  Or select back to list if no changes were made.  

![edit](https://user-images.githubusercontent.com/128923702/228904053-59d9c66d-3a40-473b-a516-94085292471d.png)

We can also view an entry individually.  To do this click on the details link next to edit link.  This will take you to the Details Page we you can view the activity.  There are links to either edit the post or head back to the list. 

![details](https://user-images.githubusercontent.com/128923702/228904280-b27d61b6-a7a4-4360-99d9-bbf462f654c6.png)

Next, we will delete an entry.  In the activities page select the delete link at the end of one of the table entries.  From there we will be take to the Delete Page.  We can select the delete button to remove an entry from the database or we can also return to the list.

![delete](https://user-images.githubusercontent.com/128923702/228904436-0f8c04f9-cac0-49da-87e3-aa0d5ec7f059.png)

And the entry has been deleted.

![postdelete](https://user-images.githubusercontent.com/128923702/228904639-303dc3fc-14d0-448d-b607-5e49f5539716.png)

With that all the major features have been covered.



