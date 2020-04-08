using System.Collections.Generic;
using System.Net.Sockets;

namespace serverChat
{
    public static class Server
    {
        public static List<Client> Clients = new List<Client>();

        public static void NewClient(Socket handle)
        {
            try {
                Client newClient = new Client(handle);
                Clients.Add(newClient);
            }
            catch { }
        }

        public static void EndClient(Client client)
        {
            try {
                client.End();
                Clients.Remove(client);
            }
            catch { }
        }

        public static void UpdateAllChats()
        {
            try {
                int countUsers = Clients.Count;
                for (int i = 0; i < countUsers; i++) {
                    Clients[i].UpdateChat();
                }
            }
            catch { }
        }

    }
}
