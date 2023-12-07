using System;
using System.Reflection;
class Program
{
    static void Populate_Lectures()
    {
        Console.WriteLine($"--------------------------------------------------------------");
        string title = "The Life and Troubled Times of Mayor Montuemhat";
        string description = "The lecture will discuss the life and times of Montuemhat, one of the best-known and most important noblemen in Egyptian history.";
        DateOnly date = new(2023, 12, 5);
        TimeOnly time = new(18, 00);
        Address address = new("47 Fifth Avenue", "New York", "NY", "USA");
        string speaker = "John Freed";
        int capacity = 300;
        Lectures eventLecture = new(title, description, date, time, address, speaker, capacity);
        Console.WriteLine("");
        Console.WriteLine($"{eventLecture.GetShortDescription("Lectures")}");
        Console.WriteLine("");
        Console.WriteLine($"\nStandard Detail:\n{eventLecture.GetStardadDetail()}");
        Console.WriteLine("");
        Console.WriteLine($"{eventLecture.GetFullDetaills()}");
    }
    static void Populate_Receptions()
    {
        Console.WriteLine($"--------------------------------------------------------------");
        string title = "December Gallery Reception";
        string description = "Join us for a festive December Gallery Reception, where art lovers gather to celebrate the holiday season, admire stunning artworks.";
        DateOnly date = new(2023, 12, 8);
        TimeOnly time = new(18, 30);
        Address address = new("Studio 21 105 N Union", "St Alexandria", "VA", "USA");
        string email = "ticket@galleryreception.com";
        Receptions eventReceptions = new(title, description, date, time, address, email);
        Console.WriteLine("");
        Console.WriteLine($"{eventReceptions.GetShortDescription("Receptions")}");
        Console.WriteLine("");
        Console.WriteLine($"\nStandard Detail:\n{eventReceptions.GetStardadDetail()}");
        Console.WriteLine("");
        Console.WriteLine($"{eventReceptions.GetFullDetaills()}");
    }
    static void Populate_Outdoors()
    {
        Console.WriteLine($"--------------------------------------------------------------");
        string title = "2023 America Outdoors Conference";
        string description = "The America Outdoors Conference & Outfitter Expo is the national gathering for outfitters and outdoor recreation providers and their staff.  The AO team delivers 3 days of content, crafted to help your business tackle challenges in the areas of marketing, risk management, operations and leadership.";
        DateOnly date = new(2023, 12, 5);
        TimeOnly time = new(09, 00);
        Address address = new("Phoenix Convention Center  100 N 3rd St", "St Phoenix", "AZ", "USA");
        string forecast = "Scattered clouds";
        Outdoor eventReceptions = new(title, description, date, time, address, forecast);
        Console.WriteLine("");
        Console.WriteLine($"{eventReceptions.GetShortDescription("Outdoors")}");
        Console.WriteLine("");
        Console.WriteLine($"\nStandard Detail:\n{eventReceptions.GetStardadDetail()}");
        Console.WriteLine("");
        Console.WriteLine($"{eventReceptions.GetFullDetaills()}");
    }
    static void Main(string[] args)
    {
        Populate_Lectures();
        Populate_Receptions();
        Populate_Outdoors();
    }
}