using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Lab09Linq;

Console.OutputEncoding = Encoding.UTF8;

// Fictional data created specifically for this laboratory assignment.
var songs = new List<Song>
{
    new() { Title = "Після дощу",       Artist = "Олена Вітер",      Genre = "Рок",         DurationSeconds = 235, ReleaseYear = 2020 },
    new() { Title = "Нова хвиля",        Artist = "Гурт Кварц",       Genre = "Рок",         DurationSeconds = 267, ReleaseYear = 2018 },
    new() { Title = "Тиха гавань",       Artist = "Марко Світло",     Genre = "Поп",         DurationSeconds = 210, ReleaseYear = 2022 },
    new() { Title = "Вогні міста",       Artist = "Гурт Кварц",       Genre = "Рок",         DurationSeconds = 302, ReleaseYear = 2024 },
    new() { Title = "Сонячний день",     Artist = "Аліна Кравець",    Genre = "Поп",         DurationSeconds = 195, ReleaseYear = 2017 },
    new() { Title = "Останній вагон",    Artist = "Данило Мороз",     Genre = "Хіп-хоп",     DurationSeconds = 244, ReleaseYear = 2021 },
    new() { Title = "Точки дотику",     Artist = "Ірина Яр",         Genre = "Джаз",        DurationSeconds = 328, ReleaseYear = 2016 },
    new() { Title = "Полярна ніч",      Artist = "Леся Брук",        Genre = "Рок",         DurationSeconds = 289, ReleaseYear = 2019 },
    new() { Title = "Листи восени",      Artist = "Ірина Яр",         Genre = "Джаз",        DurationSeconds = 351, ReleaseYear = 2023 },
    new() { Title = "Миті",             Artist = "Назар Діброва",    Genre = "Електроніка", DurationSeconds = 187, ReleaseYear = 2015 }
};

static string FormatDuration(int seconds) => $"{seconds / 60}:{seconds % 60:D2}";

static void PrintSong(Song song)
{
    Console.WriteLine($"{song.Title} | {song.Artist} | {song.Genre} | " +
                      $"{FormatDuration(song.DurationSeconds)} | {song.ReleaseYear}");
}

Console.WriteLine("Lab 9 - LINQ, variant 9 (Music)");
Console.WriteLine($"Total songs: {songs.Count}");

// 1. Filter songs by the Rock genre.
Console.WriteLine("\n1. Rock songs:");
var rockSongs = songs.Where(song => song.Genre == "Рок");
foreach (var song in rockSongs)
    PrintSong(song);

// 2. Find the longest song.
Console.WriteLine("\n2. Longest song:");
var longestSong = songs.OrderByDescending(song => song.DurationSeconds).First();
PrintSong(longestSong);

// 3. Sort songs by release year in ascending order.
Console.WriteLine("\n3. Songs by release year (ascending):");
var sortedSongs = songs.OrderBy(song => song.ReleaseYear).ThenBy(song => song.Title);
foreach (var song in sortedSongs)
    PrintSong(song);

// 4. Calculate the average song duration.
Console.WriteLine("\n4. Average song duration:");
var averageDuration = songs.Average(song => song.DurationSeconds);
Console.WriteLine(averageDuration.ToString("F2", CultureInfo.InvariantCulture) + " seconds");
