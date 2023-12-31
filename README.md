# BilConnect

## The Trailer
[Click Here](http://www.youtube.com/watch?v=Yt_V-SsEhOg&t=1s "BilConnect Trailer")

## Our Team
[Umut Bora Çakmak](https://github.com/UBoraCakmak)<br>
[A. Samed Uslu](https://github.com/sameduslu)<br>
[Murat Çağrı Kara](https://github.com/Murat-Cagri)<br>
[Celal S. Türkmen](https://github.com/celaltrk)<br>
[Emre Akgül](https://github.com/Emre-Akgul)<br>

## Build and Execution Instructions
In order to ease the deployment process, Bilconnect uses Visual Studio, which is a powerful developer tool that you can use to complete the entire development cycle in one place. It is a comprehensive, integrated development environment (IDE) that you can use to write, edit, debug, and build code and then deploy your app. For MacOS, LocalDB is not supported, meaning the configuration needs to be done using a docker container. Build and execution instructions of the project for Windows are shown.

For building and executing Bilconnect:
1. You need to install Visual Studio if you do not have it installed on your system. For that, official documentation here can be useful.
2. Similarly, you need to clone the project’s repository from GitHub to your system using “git clone”.
3. After cloning, enter the folder named BilConnect. Then, open “BilConnect.sln” with Visual Studio. 
4. Install following packages through Tools > Nuget Package Manager > Manage Nuget Packages for Solution 
* Microsoft.AspNetCore.Identity.EntityFrameworkCore v7.0.14
* Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation v7.0.0
* Microsoft.EntityFrameworkCore.SqlServer v7.0.14
* Microsoft.EntityFrameworkCore.Tools v7.0.14
* Microsoft.VisualStudio.Web.CodeGeneration.Design v7.0.11

For sending verification and forgot password emails SendGrid should be used:
For avoiding this you can use following users:
* Admin Name = bilconnect-admin     Password = Ataturk1881@
* User Mail1     =user1@ug.bilkent.edu.tr Password = TaylorSwift13?
* User Mail2     =user2@ug.bilkent.edu.tr Password = TaylorSwift13?
* Club Mail       =bilkentacm@ug.bilkent.edu.tr Password = Taytay*13 
Run the project using the IIS Express option on Visual Studio.

With this, the project using localhost will work. Server deployment of the project is found [here](https://webapi20231112110715.azurewebsites.net).

In case of a database error, if the following first four instructions are done, follow these steps:
In the SQL Server Object Explorer, using (localdb)\MSSQLLocalDB > Databases > bilconnect-app-db, delete bilconnect-app-db. 
Write Package Manager Console Update-Database

## Our Vision
BilConnect’s vision is a Bilkent Campus that is connected both online and offline.

## Our Mission
Bilconnect’s mission is to create an exclusive social platform that enables our vision through threads for Bilkenters to communicate in real time and acts as an open bazaar where people can enjoy Bilkent’s exclusive market.

## Our Motivation
Our web app was inspired by our experiences selling our used books and equipment. Let Go and similar apps were too generalized to sell our extremely specialized school equipment. Not using these apps, however, presented us with another problem: the lack of communication channels on our campus. Though Instagram pages such as bilkent_itiraf_ediyor try to fill that void, they fall short since they don’t permit live chatting and are not controlled by people from the student body.

We at BilConnect decided on a web app exclusive to Bilkenters, and solving this issue could be beneficial to Bilkent. Our team decided to develop an app that will enable online communication and enhance campus life.

## Features

#### Posts: 
Users can look for or create posts for **selling second-hand items**, **helping users to find their lost item**, **borrowing items for a specific time period**, **donating items**, **finding travel mate to split gas price**, **requesting donation**, **adopting animals**, and **selling or giving the event tickets** in the Bilkent community.

#### Tag System: 
Each post will have the main tag like **second-hand items**, **lost items**, etc., and a sub-tag like **CS223 Item**, **lost jewelry** etc. With the help of this tag system, users can personalize their feeds and make an advanced search among posts.

#### User Feed: 
Users can see the posts containing the tag that they follow in their feed. Moreover, they can save the posts to find them later and access them on their saved feed page.

#### Search: 
Users can search for the post by using keywords, filtering tags, and filtering prices and sort the results according to different parameters. They can easily find what they need and save them.

#### Messaging: 
Communication is the key tool for BilConnect. Users can easily connect with post owners by quickly messaging them privately.

#### Security: 
Only Bilkent University members can access BilConnect, and this provides security and trust in the user community. Users can rate the other user after the finished activity, and this rating point affects their trust score. 

#### User Profiles: 
Users can personalize their profiles. Also, they can check the other users' profiles to see their past activity, active posts, and trust scores.

#### User Feedback: 
Users can share their feedback and experience about BilConnect with admins.

#### Action Logs: 
Saved action logs help admins to catch bugs and improve BilConnect.

#### Chatting Forum
Our social platform offers a versatile chat system designed to facilitate both individual and group conversations. Users can engage in one-on-one chats and participate in threaded discussions. These discussions can serve various purposes, including casual conversations, interest-based groups, or community-wide discussions.

##### Search and Connect:
Easily discover and connect with other members through a dedicated search function, allowing you to initiate conversations and join discussions of interest.

##### Friendship and Privacy: 
Connect with others and create private threads for exclusive conversations, ensuring only invited members can participate.

##### Multimedia Communication:
Our chat system supports various forms of communication, including text, voice, images, and video sharing.

##### Thread Moderation:
Thread creators and administrators can control access to threads, making them open to all members or restricted to approved participants.

##### Community Feedback and Interaction: 
Users can engage with messages by liking or disliking them, influencing their visibility in the community. This promotes meaningful discussions and interactions.

##### Personalized Feed: 
The platform offers a personalized feed highlighting popular and controversial comments from the past 24 hours, fostering engagement within the community.


## Selling Points
Bilconnect is specifically designed for Bilkent University's campus. Since the platform is exclusively for the Bilkent community, there's a high level of trust. Users know they are interacting with fellow students or staff, reducing the risk of scams or fraud. In addition, exclusiveness allows faster transaction times, and even better, there is no need to worry about shipping and delivery fees. 

Bilconnect offers a comprehensive solution to different problems. There is no need to visit different websites for selling, buying, renting, and donating.

Bilconnect tries its best to ensure safety by using verified profiles and showing user reviews.

Bilconnect is more than a second-hand selling app; it also serves the purpose of connecting individuals on campus.

Bilconnect encourages sustainable practices by promoting the selling, renting, and donating of items. It will be helpful for everyone by encouraging a circular economy on campus.

## What Makes Us Special?
Our web app presents a fresh outlook on social media and an exclusive marketplace to buy from and sell to Bilkenters. An app is a tool that can help clubs coordinate and other groups on the campus communicate.
