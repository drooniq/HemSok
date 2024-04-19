using HemSok.Console;
using HemSok.Console.Models;
using System.Text.Json;

var testAPI = new TestAPI("https://localhost:7069");

await testAPI.runAPITests<Agency>(); 
await testAPI.runAPITests<Agent>();  
await testAPI.runAPITests<Category>();
await testAPI.runAPITests<County>();
await testAPI.runAPITests<Municipality>();
await testAPI.runAPITests<Residence>();
