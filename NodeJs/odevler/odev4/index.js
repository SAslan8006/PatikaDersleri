//? Employee Added

import { writeFile } from "node:fs";
writeFile(
  "employees.json",
  '{"name" : "Employee 1 Name", "salary" : 2000 }',
  "utf8",
  (err) => {
    if (err) throw err;
    console.log("Employee Created");
  }
);

//? Employee Read

import { readFile } from "node:fs";
readFile("employees.json", "utf8", (err, data) => {
  if (err) throw err;
  console.log("Employees Loading...");
  console.log(data);
});

//? Employee Updated (New Employee Added)

import { appendFile } from "node:fs";
appendFile(
  "employees.json",
  '\n{"name" : "Employee 2 Name", "salary" : 2500}',
  (err) => {
    if (err) throw err;
    console.log("New Employee Added");
  }
);

//? Employee File Deleted

// import { unlink } from "node:fs";
// unlink("employees.json", (err) => {
//   if (err) throw err;
//   console.log("Employee.json deleted");
// });