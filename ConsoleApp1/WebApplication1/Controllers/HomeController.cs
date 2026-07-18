using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    // 1. Home Page Data
    public IActionResult Index()
    {
        ViewData["FullName"] = "Jerome A. Arejola";
        ViewData["JobTitle"] = "Aspiring Web Developer";
        ViewData["Bio"] = "Welcome to my assignment hub! Here you will learn more about me.";
        ViewData["ProfileImg"] = "https://media.istockphoto.com/id/689364180/vector/smiling-cartoon-face-positive-people-emotion-icon.jpg?s=612x612&w=0&k=20&c=2olrbVI2dkVyR0XKaMs4cSDrzpA4zH4FrCfZ_rKwVjU=";

        return View();
    }

    // 2. About Me Page Data
    public IActionResult AboutMe()
    {
        ViewData["Program"] = "BS in Information Technology";
        ViewData["Status"] = "Midterm Phase";

        return View();
    }

    // 3. Projects Page Data (No lists, just separate string slots)
    public IActionResult Projects()
    {
        // Project 1
        ViewData["P1Title"] = "Console StudentSystem";
        ViewData["P1Desc"] = "A console-based student information system for managing academic records.";
        ViewData["P1Link"] = "https://github.com/jeromearejola-30/BSIT31E1_PRELIM_H1_AREJOLA_JEROME.git";

        // Project 2
        ViewData["P2Title"] = "Console Calculator";
        ViewData["P2Desc"] = "A simple console application for performing basic arithmetic operations.";
        ViewData["P2Link"] = "https://github.com/jeromearejola-30/BSIT31E1_PRELIM_A2_AREJOLA_JEROME.git";

        // Project 3
        ViewData["P3Title"] = "Console Student Management System Using OOP";
        ViewData["P3Desc"] = "A record keeping system mapping student academic tracking paths.";
        ViewData["P3Link"] = "https://github.com/jpacaonces/BSIT31E1_PRELIM_H1_PACAONCES_JANSSEN.git";

        return View();
    }

    // 4. Contact Page Data
    public IActionResult Contact()
    {
        ViewData["Email"] = "jeromearejola30@gmail.com";
        ViewData["Phone"] = "+63900000000";
        ViewData["GitHubUrl"] = "https://github.com/jeromearejola-30";

        return View();
    }

    public IActionResult Skills()
    {
        return View(); // Leaving this static HTML since skills rarely change
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}