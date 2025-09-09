using Microsoft.AspNetCore.Mvc;
using Orion.DataAccess.Postgres.Tools;
using Orion.Domain.IRepositories;

namespace Orion.API.AWBuildVersion.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class AWBuildVersionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AWBuildVersionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var versions = await _unitOfWork.AWBuildVersions.GetAllAsync();
            return Ok(versions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var version = await _unitOfWork.AWBuildVersions.GetByIdAsync(id);
            if (version == null) return NotFound();
            return Ok(version);
        }

        [HttpPost]
        public async Task<IActionResult> Create(DataAccess.Postgres.Entities.AWBuildVersion version)
        {
            await _unitOfWork.AWBuildVersions.AddAsync(version);
            await _unitOfWork.CompleteAsync();
            return CreatedAtAction(nameof(GetById), new { id = version.SystemInformationID }, version);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DataAccess.Postgres.Entities.AWBuildVersion version)
        {
            var existing = await _unitOfWork.AWBuildVersions.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.DatabaseVersion = version.DatabaseVersion;
            existing.VersionDate = version.VersionDate;
            existing.ModifiedDate = version.ModifiedDate;

            _unitOfWork.AWBuildVersions.Update(existing);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _unitOfWork.AWBuildVersions.GetByIdAsync(id);
            if (existing == null) return NotFound();

            _unitOfWork.AWBuildVersions.Delete(existing);
            await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}