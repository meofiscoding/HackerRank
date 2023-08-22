"use strict";

const fs = require("fs");
const https = require("https");

process.stdin.resume();
process.stdin.setEncoding("utf-8");

let inputString = "";
let currentLine = 0;

process.stdin.on("data", function (inputStdin) {
  inputString += inputStdin;
});

process.stdin.on("end", function () {
  inputString = inputString.split("\n");

  main();
});

function readLine() {
  return inputString[currentLine++];
}

async function getTeams(year, k) {
  // write your code here
  // API endpoint template: https://jsonmock.hackerrank.com/api/football_matches?competition=UEFA%20Champions%20League&year=<YEAR>&page=<PAGE_NUMBER>
  // TODO:
  // call api to get total pages
  const totalPages = await getTotalPages(year);
  // using concurrent requests to get all teams to reduce time
  const promises = [];
  for (let i = 1; i <= totalPages; i++) {
    promises.push(getTeamsByPage(year, i));
  }
  const teams = await Promise.all(promises);
  // declare a map to store teams and their occurences
  const map = new Map();
  // loop through all teams to count occurences of team 1 and team 2 and add them to map
  for (const team of teams) {
    for (const match of team.data) {
      const team1 = match.team1;
      const team2 = match.team2;
      if (map.has(team1)) {
        map.set(team1, map.get(team1) + 1);
      } else {
        map.set(team1, 1);
      }
      if (map.has(team2)) {
        map.set(team2, map.get(team2) + 1);
      } else {
        map.set(team2, 1);
      }
    }
  }
    // loop through map to get teams with occurences >= k
    const result = [];
    for (const [key, value] of map) {
      if (value >= k) {
        result.push(key);
      }
    }

    // sort result
    result.sort();
    return result;
}

async function getTeamsByPage(year, page) {
  return new Promise((resolve, reject) => {
    https
      .get(
        `https://jsonmock.hackerrank.com/api/football_matches?competition=UEFA%20Champions%20League&year=${year}&page=${page}`,
        (res) => {
          let data = "";
          res.on("data", (chunk) => {
            data += chunk;
          });
          res.on("end", () => {
            const teams = JSON.parse(data);
            resolve(teams);
          });
        }
      )
      .on("error", (err) => {
        reject(err);
      });
  });
}

async function getTotalPages(year) {
  // call API to get total pages
  return new Promise((resolve, reject) => {
    https
      .get(
        `https://jsonmock.hackerrank.com/api/football_matches?competition=UEFA%20Champions%20League&year=${year}`,
        (res) => {
          let data = "";
          res.on("data", (chunk) => {
            data += chunk;
          });
          res.on("end", () => {
            const totalPages = JSON.parse(data).total_pages;
            debugger;
            resolve(totalPages);
          });
        }
      )
      .on("error", (err) => {
        reject(err);
      });
  });
}

async function main() {
  const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

  const year = parseInt(readLine().trim());
  const k = parseInt(readLine().trim());

  const teams = await getTeams(year, k);

  for (const team of teams) {
    ws.write(`${team}\n`);
  }
}