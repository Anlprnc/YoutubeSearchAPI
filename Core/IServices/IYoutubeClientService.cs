using YoutubeAPI.Core.Models;

namespace YoutubeAPI.Core.IServices
{
    public interface IYoutubeClientService
    {
        Task<SearchResponseDto> SearchAsync(string q, int maxResult);
        Task<ChannelResponseDto> SearchChannelAsync(string channelName, int maxResult);
    }
}