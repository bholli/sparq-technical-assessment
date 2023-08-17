
using sparq_technical_assessment;

//code assumes TVlalue is string

Console.WriteLine("welcome to the sparq technical assessment");

StringMap<string> map = new StringMap<string>();

map.DefaultValue = "default";
Console.WriteLine("Default value: " + map.DefaultValue);


map.AddElement("something", "good");
Console.WriteLine(map.GetValue("brandon"));

//count
Console.WriteLine("Count: " + map.Count);

//add element
map.AddElement("crystal", "holliday");

//count
Console.WriteLine("Count: " + map.Count);

//attempt to add element with empty key; should throw exception
map.AddElement("", "boom");