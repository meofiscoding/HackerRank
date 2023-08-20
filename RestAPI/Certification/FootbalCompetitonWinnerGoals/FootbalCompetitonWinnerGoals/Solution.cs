using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

class Result
{

    /*
     * Complete the 'getWinnerTotalGoals' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING competition
     *  2. INTEGER year
     */

    public static int getWinnerTotalGoals(string competition, int year)
    {
        // Write your code here
        int result = 0;
        string url = $"https://jsonmock.hackerrank.com/api/football_competitions?name={competition}&year={year}";
        // get the team who won the competition
        var response = GetResponse(url);
        // deserialize json to object
        var responseData = JsonSerializer.Deserialize<Competition>(response) ?? new Competition();
        // get winner name
        string winner = responseData.winner;


    }

    private static string GetResponse(string url_page)
    {
        // get response from url
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage response = client.GetAsync(url_page).Result;
        if (response.IsSuccessStatusCode)
        {
            // get response as json
            var dataObjects = response.Content.ReadAsStringAsync().Result;
            return dataObjects;
        }
        else
        {
            return string.Empty;
        }
    }
}

class Competition
{
    public string name { get; set; }
    public string country { get; set; }
    public int year { get; set; }
    public string winner { get; set; }
    public string runnerup { get; set; }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string competition = Console.ReadLine();

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.getWinnerTotalGoals(competition, year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
