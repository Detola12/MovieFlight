class Program{
    static List<int> store_movie = new List<int>();
    static void Main(){
        int flight_length = 80;
        List<int> movie_lengths = new List<int>(){20, 45, 40, 65, 55, 30};

        checkMovie(flight_length, movie_lengths);

    }

    static bool checkMovie(int length, List<int> movie){
        bool result = false;
        
        for(int i = 0; i < movie.Count; i++){
            for(int x = 0; x < movie.Count; x++){
                int temp = movie[i];


                if(temp + movie[x] <= length && i != x){
                    result = true;
                    if(!store_movie.Contains(x)){
                        store_movie.Add(i);
                        Console.WriteLine($"Movie {i + 1} and Movie {x + 1}");
                    }
                }
            }
        }

        return result;
    }
}