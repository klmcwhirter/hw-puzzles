using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hwpuzzles.Core.Models;

namespace hwpuzzles.Controllers
{
    /// <summary>
    /// PuzzleBoardController
    /// </summary>
    [Produces("application/json")]
    [Route("api/v1/puzzleboard")]
    public class PuzzleBoardController : Controller
    {
        public IGenerator<PuzzleBoard> PbGenerator { get; }
        
        public PuzzleBoardController(IGenerator<PuzzleBoard> pbGenerator)
        {
            PbGenerator = pbGenerator;
        }


        // GET api/puzzleboard/Fruit
        /// <summary>
        /// Gets a generated PuzzleBoard using the PuzzleId passed in
        /// </summary>
        /// <param name="name">Name of the Puzzle to generate</param>
        /// <returns>PuzzleBoard instance</returns>
        [HttpGet("{name}")]
        public PuzzleBoard Get(string name) => PbGenerator.Generate(name, false);
    }
}
