#XAMARIN FORMS PCL HOW TO ADD GOOGLE ANALYTICS, ANDROID & IOS 
1. Create project Xamarin forms , PCL
2. Now need to import packages packages for both Android and iOS projects.
3. Import package for android project. Xamarin.GooglePlayService.Analytics 
     Import package for iOS project. Google Analytics for iOS
4. We need  initialize Google Analytics Service method at the application start
       In Android project MainActivity / OnCreate insert 
            GAService.GetGASInstance().Initialize_NativeGAS(this);
       Do the same for  iOS project  AppDelegate / FinishedLaunching  insert
            GAService.GetGASInstance().Initialize_NativeGAS();
5. In the main project create interface (IGAService)
6. Next, in android project lets create folder, name it Analytics and in that folder create class  and name it GAService.
7. Do the same  in iOS project. Create folder, name it Analytics and in that folder create class  and name it GAService.
8. Now in our main project create new class lets name it GASCall
9. In your main project create new class name it GAEventCategory. We will use it to track events. 
10. Finally create button we need it to test our app. Open main project main startup class. GoogleAnlalyticsTestPage.xaml 
11. Now add function ,  open GoogleAnlalyticsTestPage.xaml.cs
12. Final step.. lets test it
 
