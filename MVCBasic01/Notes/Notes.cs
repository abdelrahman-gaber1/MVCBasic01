using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Security.Claims;

namespace MVCBasic01.Notes
{
    public class Notes
    {
        #region Asp.Net Projects

        // to make Web App use Asp.Net or Blazer we will use Asp.Net
        // client side front end (user) we make it using html - css - javascript
        // server side back end we make it using C#(asp.net) or php(laravel) or Javascript(nodejs)

        // http request consist of the url which send to server side 
        // server side will take http request and send it to database
        // data base send date to server side that will send it to client side
        // http response contain statues code and type of data 


        // Asp.Net framework can use to make three type of project 
        //1.Asp.Net web forms (bad performance)
        //2.Asp.Net web pages 
        //3.Asp.Net mvc

        // Asp.Net Core can use to make Two type of project 
        //1.Asp.Net Razer Pages(web pages) (Front + Back ) (MVVM)(Model View View Model) 
        //2.Asp.Net MVC (Front + Back )  (Model View Controller) (Better Structure)

        // You can build only Back End Using ASP.Net Web Api (Services) (End Point)
        // Then consume it in Front end
        // ASP.Net Web APi (Model Controller) 
        // view = front end project

        // if the scope of the project is large we use Asp.Net Web Api to make single page App
        // if the scope of the project is small we can use Asp.Net Mvc 

        // signalR to make real time application we can use it in Mvc or wep api
        #endregion

        #region Asp.Net Vs Asp.Framework Deployment

        // if the project is Asp.Framework we can't deployment it unless server have os windows 
        // IIS : Internet Information System (local server)
        // IIS : web sever for windows Contain only on os Windows by default
        // to deploy any project we deploy it in web server
        // the problem that is other os didn't have IIS
        // IIS Contain System.web (nameSpace) that need by any project 
        // Web Server Use to Handle Requset 
        // we will deploy or project on IIS as local server
        // linux have apache inseted of IIS


        //                                       Solution
        // The Appliction contain kestrel console app work as internal web server (contain BCL)
        // external web server (IIS - Apache - Nginx) only take request from client side and pass it to kestrel
        // Kestrel run based on platform Windows(SDK for it) linex(SDK for it)
        // SDK contain system.web and BCL
        // Kestrel(MiddleWare) send request to project 

        //                               Two Profiles for Deployment
        //With Reverse Proxy Server 
        //Without  Reverse Proxy Server (Most Recommended)

        #endregion

        #region MVC
        //MVC ( Model(Data) - View(HTML) - Controller(Processing) ) : Archetecture Pattern(Structure of the project)
        //MVC : Achive Consept Separation of Concern


        //                          Life cycle in MVC
        //1.Request send form client side(user)
        //2.kestrel take request and handel it then
        //2.Contraller take request and Processing it then
        //3.Send to Model to retrive data from data base
        //4.controller take data and send it to view


        //              Controller
        // Class Inherit From Class(Controller)
        // Its Name Must End With Controller
        // Contain Public Non-Static Functions Called Actions
        // Basically Have 5 Actions[CRUD Operations]
        // - GetAll , GetbyId , Update , Delete , Add

        #endregion

        #region MVC Project Structure
        //Connected services : Cloud Service that you connect with your project 
        //Dependencies --> Analyzer + Framework + Package + Project(reference) --> kestrel + App   
       
        
        //Properties -->launchSettings--> settings when run app --> contain two profile (iis setting + nameOfApp(kestrel))
        // kestrel has the same name of app because he is part of the app
        //                               Properties
        //commandName : if you want to run your app using console
        //launchBrowser : if true after deploy lanch the app
        //applicationUrl : url to lunch app (http + https)
        //environmentVariables : determine which environment the project in
        //environmentVariables : use it if i want to use something in specific environment
        //like exception page if you want apper it in development only

        //WSL(windows subsystem for linux) profile : if you have windows and linux and you want to run in linux


        // appsettings : any thing changes from one environment to anthor
        // appsettings : for testing , development , production
        // AllowedHosts : hosts that allaw to acces my project 
        // ConnectionStrings : added in appsettings to connect with database  
        // you can add another connectionStrings 



        // after .net 5 there is no program and startup only program that contain all thing in startup
        //
        #endregion
    }

}
