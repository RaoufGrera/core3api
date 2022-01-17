using System.Collections.Generic;
using System.Threading.Tasks;
using core3api.Helpers;
using core3api.Model;
using SystemData.Models;

namespace core3api.Interfaces
{
    public interface IMessageRepository
    {
        void AddGroup(Group group);
        void RemoveConnection(Connection connection);
        Task<Connection> GetConnection(string connectionId);
        Task<Group> GetMessageGroup(string groupName);
        Task<Group> GetGroupForConnection(string connectionId);
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<VMessage>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<VMessage>> GetMessageThread(string currentUsername, string recipientUsername);
    }
}