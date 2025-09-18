using Azure.Core;
using ExperCT.Models;

public static class SessionManager
{
    public static Technicien CurrentTechnicien { get; set; }
    public static Client CurrentClient { get; set; }

    public static bool IsTechnicienConnected => CurrentTechnicien != null;
    public static bool IsClientConnected => CurrentClient != null;

    public static void Clear()
    {
        CurrentTechnicien = null;
        CurrentClient = null;
    }

    public static void LoginClient (Client client)
    {
        CurrentClient = client;
    }

    public static void LoginTechnicien (Technicien technicien)
    {
        CurrentTechnicien = technicien;
    }

    public static void Logout ()
    {
        CurrentClient = null;
        CurrentTechnicien = null;
    }
}
