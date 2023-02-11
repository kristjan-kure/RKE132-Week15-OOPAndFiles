List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp array");
    //ReadDataFromArray(tempArray);
    Movie newMovie = new Movie(tempArray[0], tempArray[1]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favourite movies '{movie.Title}' has rating {movie.Rating}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\krist\source\repos\Week14OOP\Data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);
    //return dataFromFile;

    return File.ReadAllLines(filePath);
} 

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title; //fields
    string rating;
    string year;

    //getter
    public string Title
    {
        get { return title; }
    }

    //getter
    public string Year
    {
        get { return year; }
    }

    public string Rating
    {
        get { return rating; }
    }


    public Movie(string _title, string _rating)
    {
        title = _title; 
        rating = _rating;
    }
}


