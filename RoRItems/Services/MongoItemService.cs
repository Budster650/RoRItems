using Microsoft.AspNetCore.Hosting;
using RoRItems.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoRItems.Services
{
    public class MongoItemService
    {

        public IEnumerable<Item> GetItems()
        {
            /*
             * From JsonFileItemService, for reference:
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Item[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
            */
            return JsonSerializer.Deserialize<Item[]>("");
        }
    }
}
