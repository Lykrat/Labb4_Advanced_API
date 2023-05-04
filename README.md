# Labb4_Advanced_API
In Person there is a get that gets all the people in the Database. In the Links there are a couple of callable funcions. In the first it takes a ID of a Person and shows all of that persons intrests. In the Second it takes an id for a listIntrest and finds that single one. In the third it takes a id for person and gets every single ListInterest thats is connected with it. In the last HTTPPost It takes a formated LinkIntrest and then adds it to the database if it is compatible. Example of that is below.

//Example of adding a LinkIntrests
{
  "link": "string",
  "personId": 0,
  "interestsId": 0,
}
