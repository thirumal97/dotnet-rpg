using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         //List<Character> GetAllCharacters();
        // Character GetCharacterById(int id);
        // List<Character> AddCharacter(Character newCharacter);
        //Task<List<Character>> GetAllCharacters();
        //Task<Character> GetCharacterById(int id);
        //Task<List<Character>> AddCharacter(Character newCharacter);
        //Task<ServiceResponse<List<Character>>> GetAllCharacters();
        //Task<ServiceResponse<Character>> GetCharacterById(int id);
        //Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);

        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);    
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);   
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id); 
    }
} 