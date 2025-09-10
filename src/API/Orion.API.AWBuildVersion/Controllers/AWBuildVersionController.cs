using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orion.DataAccess.Postgres.Tools;

namespace Orion.API.AWBuildVersion.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AwBuildVersionController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var versions = await unitOfWork.AwBuildVersions.GetAllAsync();
            return Ok(versions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var version = await unitOfWork.AwBuildVersions.GetByIdAsync(id);
            if (version == null) return NotFound();
            return Ok(version);
        }

        [HttpPost]
        public async Task<IActionResult> Create(DataAccess.Postgres.Entities.AWBuildVersion version)
        {
            await unitOfWork.AwBuildVersions.AddAsync(version);
            await unitOfWork.CompleteAsync();
            return CreatedAtAction(nameof(GetById), new { id = version.SystemInformationID }, version);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DataAccess.Postgres.Entities.AWBuildVersion version)
        {
            var existing = await unitOfWork.AwBuildVersions.GetByIdAsync(id);
            if (existing == null) return NotFound();

            existing.DatabaseVersion = version.DatabaseVersion;
            existing.VersionDate = version.VersionDate;
            existing.ModifiedDate = version.ModifiedDate;

            unitOfWork.AwBuildVersions.Update(existing);
            await unitOfWork.CompleteAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await unitOfWork.AwBuildVersions.GetByIdAsync(id);
            if (existing == null) return NotFound();

            unitOfWork.AwBuildVersions.Delete(existing);
            await unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}