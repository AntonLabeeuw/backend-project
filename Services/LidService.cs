namespace Leden.API.Services;

public interface ILidService
{
    Task<Groep> AddGroep(Groep newGroep);
    Task<Lid> AddLid(Lid newLid);
    Task<Tak> AddTak(Tak newTak);
    Task<List<Groep>> GetAllGroepen();
    Task<List<Lid>> GetAllLeden();
    Task<List<Tak>> GetAllTakken();
    Task<Groep> GetGroep(Guid id);
    Task<List<Lid>> GetLedenByGroepId(Guid GroepId);
    Task<List<Lid>> GetLedenByTakId(Guid TakId);
    Task<Lid> GetLid(Guid id);
    Task<Tak> GetTak(Guid id);
    Task<Tak> UpdateTak(Tak tak);
}

public class LidService : ILidService
{
    public readonly ILidRepository _lidRepository;
    public readonly ITakRepository _takRepository;
    public readonly IGroepRepository _groepRepository;

    public LidService(ILidRepository lidRepository, ITakRepository takRepository, IGroepRepository groepRepository)
    {
        _lidRepository = lidRepository;
        _takRepository = takRepository;
        _groepRepository = groepRepository;
    }

    public async Task<List<Lid>> GetAllLeden() => await _lidRepository.GetAllLeden();

    public async Task<Lid> GetLid(Guid id) => await _lidRepository.GetLid(id);

    public async Task<List<Lid>> GetLedenByTakId(Guid TakId) => await _lidRepository.GetLedenByTakId(TakId);

    public async Task<List<Lid>> GetLedenByGroepId(Guid GroepId) => await _lidRepository.GetLedenByGroepId(GroepId);

    public async Task<Lid> AddLid(Lid newLid) => await _lidRepository.AddLid(newLid);

    public async Task<List<Tak>> GetAllTakken() => await _takRepository.GetAllTakken();

    public async Task<Tak> GetTak(Guid id) => await _takRepository.GetTak(id);

    public async Task<Tak> AddTak(Tak newTak) => await _takRepository.AddTak(newTak);

    public async Task<Tak> UpdateTak(Tak tak) => await _takRepository.UpdateTak(tak);

    public async Task<List<Groep>> GetAllGroepen() => await _groepRepository.GetAllGroepen();

    public async Task<Groep> GetGroep(Guid id) => await _groepRepository.GetGroep(id);

    public async Task<Groep> AddGroep(Groep newGroep) => await _groepRepository.AddGroep(newGroep);
}