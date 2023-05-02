//#region Task1
//string Model = @"C:\Users\LENOVO\Desktop\FileDirector\Models";
//Directory.CreateDirectory(Model);
//string Data = @"C:\Users\LENOVO\Desktop\FileDirector\Models\Data";
//Directory.CreateDirectory(Data);
//string json = @"C:\Users\LENOVO\Desktop\FileDirector\Models\Data\jsonData.json ";
//File.Create(json);
//#endregion


#region Task2
using Newtonsoft.Json;

string url = "https://jsonplaceholder.typicode.com/posts";
HttpClient client = new HttpClient();
var result = client.GetStringAsync(url).Result;
Object obyect = JsonConvert.DeserializeObject<Object>(result);
//Console.WriteLine( obyect);
string json = @"C:\Users\LENOVO\Desktop\FileDirector\Models\Data\jsonData.json ";
using (StreamWriter sw = new StreamWriter(json))
{
    sw.WriteLine(JsonConvert.SerializeObject(obyect));
}
#endregion