namespace PokemonReviewApp.Dto
    // DTO limits the data sent out as well as data coming in
{
    public class PokemonDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
