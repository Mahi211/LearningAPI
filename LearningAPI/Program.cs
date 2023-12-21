using LearningAPI;
using System.Text.Json;
using System.Text.Json.Serialization;


var client = new HttpClient();
var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
var result = client.GetAsync(endpoint).Result;
var json = result.Content.ReadAsStringAsync().Result;
var posts = JsonSerializer.Deserialize<List<Post>>(json);
var userId3 = posts.Where(x => x.userId == 7).ToList();
var client1 = new HttpClient();
var endpoint1 = new Uri("https://jsonplaceholder.typicode.com/comments");
var result1 = client1.GetAsync(endpoint1).Result;
var json1 = result1.Content.ReadAsStringAsync().Result;
var comments = JsonSerializer.Deserialize<List<Comments>>(json1);
var userId1 = comments.Where(x => x.email == "Aniyah.Ortiz@monte.me").ToList();
Post newPost = new()
{
    title = "Test Post",
    body = "Hey",
    userId = 13

};


int i = 0;




