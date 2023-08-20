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
     * Complete the 'getNumDraws' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER year as parameter.
     */

    //public static int getNumDraws(int year)
    //{
    //    // Write your code here
    //    int result = 0;
    //    string url = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}";
    //    // response is a JSON with 5 fields: page, per_page, total, total_pages, data
    //    // read all data in all page to get draw matches
    //    int page = 0;
    //    int total_pages = 1;
    //    while (page <= total_pages)
    //    {
    //        string url_page = $"{url}&page={page}";
    //        var response = GetResponse(url_page);
    //        // deserialize json to object
    //        var responseData = JsonSerializer.Deserialize<Dictionary<string, object>>(response) ?? new Dictionary<string, object>();
    //        var data = responseData["data"];
    //        if (string.IsNullOrEmpty(data.ToString()))
    //        {
    //            return 0;
    //        }
    //        List<Match> matches = JsonSerializer.Deserialize<List<Match>>(data.ToString()) ?? new List<Match>();
    //        total_pages = Convert.ToInt32(responseData["total_pages"].ToString());
    //        foreach (var item in matches)
    //        {
    //            if (item.team1goals == item.team2goals)
    //            {
    //                result++;
    //            }
    //        }
    //        page++;
    //    }
    //    return result;
    //}

    //    private static string GetResponse(string url_page)
    //    {
    //        // get response from url
    //        HttpClient client = new HttpClient();
    //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    //        HttpResponseMessage response = client.GetAsync(url_page).Result;
    //        if (response.IsSuccessStatusCode)
    //        {
    //            // get response as json
    //            var dataObjects = response.Content.ReadAsStringAsync().Result;
    //            return dataObjects;
    //        }
    //        else
    //        {
    //            return string.Empty;
    //        }
    //    }
    //}
    public static int getNumDraws(int year)
    {
        int result = 0;
        string url = $"https://jsonmock.hackerrank.com/api/football_matches?year={year}";

        int total_pages = GetTotalPages(url);

        List<Task<List<Match>>> fetchTasks = new List<Task<List<Match>>>();

        // Calculate the number of pages to fetch concurrently
        int batchSize = Math.Min(total_pages, Environment.ProcessorCount * 2);

        for (int batchStart = 1; batchStart <= total_pages; batchStart += batchSize)
        {
            int batchEnd = Math.Min(batchStart + batchSize - 1, total_pages);

            var batchTasks = Enumerable.Range(batchStart, batchEnd - batchStart + 1)
                .Select(page => $"{url}&page={page}")
                .Select(GetMatchesAsync);

            fetchTasks.AddRange(batchTasks);
        }
        // Wait for all tasks to complete
        Task.WhenAll(fetchTasks).Wait();

        // Process fetched data
        foreach (var matches in fetchTasks.Select(task => task.Result))
        {
            foreach (var item in matches)
            {
                if (item.team1goals == item.team2goals)
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static int GetTotalPages(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                var responseData = JsonSerializer.Deserialize<Dictionary<string, object>>(dataObjects) ?? new Dictionary<string, object>();
                return Convert.ToInt32(responseData["total_pages"].ToString());
            }
        }

        return 0;
    }

    private static async Task<List<Match>> GetMatchesAsync(string url_page)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(url_page);

            if (response.IsSuccessStatusCode)
            {
                var dataObjects = await response.Content.ReadAsStringAsync();
                var responseData = JsonSerializer.Deserialize<Dictionary<string, object>>(dataObjects) ?? new Dictionary<string, object>();
                var data = responseData["data"];

                if (!string.IsNullOrEmpty(data.ToString()))
                {
                    return JsonSerializer.Deserialize<List<Match>>(data.ToString()) ?? new List<Match>();
                }
            }
        }

        return new List<Match>();
    }

    class Match
    {
        public string competition { get; set; }
        public int year { get; set; }
        public string round { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public string team1goals { get; set; }
        public string team2goals { get; set; }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.getNumDraws(year);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}