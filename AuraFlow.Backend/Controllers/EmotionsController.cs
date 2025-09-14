using AuraFlow.Application.DTOs;
using AuraFlow.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AuraFlow.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmotionsController : ControllerBase
    {
        private readonly IEmotionService _emotionService;

        public EmotionsController(IEmotionService emotionService)
        {
            _emotionService = emotionService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "anonymous";
            var records = await _emotionService.GetUserEmotionsAsync(userId);
            return Ok(records);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] EmotionRecordDto dto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "anonymous";
            var id = await _emotionService.CreateEmotionRecordAsync(dto, userId);
            return Ok(new { id });
        }
    }
}
