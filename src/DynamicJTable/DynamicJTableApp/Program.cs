using System;
using System.Text.Json;
using DynamicJTable;

namespace DynamicJTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var jtable = new DynJTable();
            jtable.Actions.CreateAction = "/URL/Create/";
            jtable.Fields.Add(new djtField { Name = "Column1", Title = "Id"});
            jtable.Fields.Add(new djtField { Name = "Column2", Title = "Name" });
            jtable.Fields.Add(new djtField { Name = "Column3", Title = "Description" });
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(jtable, options);
            Console.WriteLine(jsonString);
            
        }
    }
}
