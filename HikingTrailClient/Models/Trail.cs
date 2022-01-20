using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HikingTrailClient.Models
{
  public class Trail
  {
    public int TrailId { get; set; }
    public string Name { get; set; }
    public double Length { get; set; }
    public string Configuration { get; set; }
    public int ElevationGain { get; set; }
    public string Difficulty { get; set; }
    public string FamilyFriendly { get; set; }
    public double DistanceFromPdx { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Season { get; set; }

    public static List<Trail> GetTrails()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Trail> trailList = JsonConvert.DeserializeObject<List<Trail>>(jsonResponse.ToString());

      return trailList;
    }

    public static Trail GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Trail trail = JsonConvert.DeserializeObject<Trail>(jsonResponse.ToString());

      return trail;

    }
  }
}