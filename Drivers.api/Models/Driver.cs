using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Drivers.api.Models;

public class Driver
{
    // _id: ObjectId("653116783aee33a07ee7a248"),
    // name: 'Rosberg',
    // surname: 'Nico',
    // ranking: 7,
    // points: 89,
    // wins: 0,
    // poles: 0,
    // bestPosition: 5,
    // bestPositionTimes: 2,
    // nationality: 'Germany',
    // team: 'Mercedes GP',
    // teamPoints: 165




  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string Id { get; set; } = string.Empty;
  [BsonElement("name")]
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
