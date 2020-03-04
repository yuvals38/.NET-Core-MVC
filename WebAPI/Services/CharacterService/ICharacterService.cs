using System.Collections.Generic;
using WebAPI.Models;
using System.Threading.Tasks;
public interface ICharacterService
{   Task<ServiceResponse<List<Character>>> GetAllCharacters();
    Task<ServiceResponse<Character>> GetCharacterById(int id);
    Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
}