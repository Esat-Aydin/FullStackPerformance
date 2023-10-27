// using MongoDB.Bson.Serialization.Attributes;
// using MongoDB.Bson;

namespace Drivers.api.Models;

public class Driver
{
  public string Id { get; set; } = string.Empty;
  public string name { get; set; } = string.Empty;
  public string surname {get; set;} = string.Empty;
  public int? ranking {get; set;}
  public int? points {get; set;}
  public int? lastRace {get; set;}
  public int? wins {get; set;}
  public int? poles {get; set;}
  public int? bestPosition {get; set;}
  public int? bestPositionTimes {get; set;}
  public string nationality {get; set;} = string.Empty;
  public string team {get; set;} = string.Empty;
  public int? teamPoints {get; set;}
  
}

// public class Driver // MongoDb
// {
//   [BsonId]
//   [BsonRepresentation(BsonType.ObjectId)]
//   public string Id { get; set; } = string.Empty;
//   [BsonElement("name")]
//   public string name { get; set; } = string.Empty;
//   public string surname {get; set;} = string.Empty;
//   public int? ranking {get; set;}
//   public int? points {get; set;}
//   public int? lastRace {get; set;}
//   public int? wins {get; set;}
//   public int? poles {get; set;}
//   public int? bestPosition {get; set;}
//   public int? bestPositionTimes {get; set;}
//   public string nationality {get; set;} = string.Empty;
//   public string team {get; set;} = string.Empty;
//   public int? teamPoints {get; set;}
//   public Car? CarOfDriver {get; set;}
  
// }