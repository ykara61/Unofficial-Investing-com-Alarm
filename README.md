#  1.Objective

The aim of this repository is to retrieve real-time currency values from the **Investing.com** website and create an application that generates alerts based on this data.

<p>
    <img src="/Images/BothWindow.png" alt>
</p>

# 2. Why .NET/.NET Core for this Unofficial investing alarm

At this point in time, The .NET Core are widely adoped by a large community of enterprise developers. It paves way for use programming language like C# for making currency value alarm application. The enterprise developers can integrate this functionality into Console Application, Windows Application and Xamarin mobile applications etc.

# 3. Investing.com Website Currency Alarm (Unofficial)


## 3a. Development Environment
- Windows 10
- Visual Studio 2022 with latest updates

## 3b. Runtime Requirements
- .NET Runtime [(.NET 6)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Windows OS
- Suitable **investing.com** website link

## First Run

* Using the application is straightforward. On the first run, the combo box will be empty, meaning there are no linked instruments (currencies). To add the first instrument, click the "Add" button. A new form will appear where you can add a new instrument by entering a title and link.

<p>
    <img src="/Images/FirstRunAddNew.png" alt>
</p>


## Running The APP

The application allows you to select an instrument from a drop-down menu (also known as a combo box) that you have previously added. You also have the option to specify a range for the selected instrument by defining a minimum and/or maximum limit. The minimum limit can be entered in the text box located in the bottom left corner, while the maximum limit can be entered in the text box located in the bottom right corner. If the selected instrument exceeds the defined limits, the application will provide an audible warning.

<p>
    <img src="/Images/RunningForm.png" alt>
</p>




- As demonstrated below, the application is designed to retrieve real-time data from a specified investment website link at regular intervals in order to provide the most up-to-date information for analysis and decision-making purposes.

<p>
    <img src="/Images/RealTimeDemostrate.png" width="65%" height="65%">
</p>

The complete .NET project source for the publisher is available in this repository.


