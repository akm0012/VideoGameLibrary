# VideoGameLibrary

This is a simple API that I am using to help me pratice reactive programming in Android.

The avaliable endpoints are: 

### `GET /VideoGame/ids`
* This will return a list of all the Video Game Ids in the library. 

Example: 
```
{
    "gameIds": [
        1,
        2,
        3,
        5,
        7,
        11,
        13,
        17,
        19
    ]
}
```

<br/>

### `GET /VideoGame/{gameId}`
Example:
```
{
    "id": 1,
    "name": "The Legend of Zelda: Ocarina of Time",
    "description": "The Legend of Zelda: Ocarina of Time is an action-adventure game developed and published by Nintendo for the Nintendo 64. It was released in Japan and North America in November 1998, and in PAL regions the following month. Ocarina of Time is the fifth game in The Legend of Zelda series, and the first with 3D graphics. ",
    "isMultiPlayer": false,
    "dateReleased": "November 21, 1998",
    "developerStudio": "Nintendo"
}
```

<br/>

### `GET /VideoGame/Media/{gameId}`
Example:
```
{
    "mediaId": 100,
    "gameId": 1,
    "gamePosterUrl": "https://m.media-amazon.com/images/M/MV5BZjc3MmMzNGItYmEzYy00MWFhLWI0NDQtMWE3Y2Q1NjE1OWRlXkEyXkFqcGdeQXVyNzcyMjAwNTE@._V1_.jpg",
    "gameTrailerUrl": "https://www.youtube.com/watch?v=_NElFLzgdUs"
}
```
