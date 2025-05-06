namespace LRS;
using System.Runtime.InteropServices;


public class dll
{
    //座位
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getSeatHead();
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int addSeat(IntPtr head, int room, int seat, int isOccupied);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int removeSeat(IntPtr head, int room, int seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findSeatByRoom(IntPtr head, int room);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findSeatBySeat(IntPtr head, int seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr findSeatByIsOccupied(IntPtr head, int isOccupied);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr returnAllSeats(IntPtr head);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void freeSeat(IntPtr head);

    //用户
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getUserHead();
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int addUser(IntPtr head, IntPtr name, IntPtr email, IntPtr password, int isAdmin, IntPtr seat);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int deleteUser(IntPtr head, IntPtr email, IntPtr password);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr returnAllUser(IntPtr head, IntPtr email);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int changeUsername(IntPtr head, IntPtr name, IntPtr email);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int changeUserPassword(IntPtr head, IntPtr email, IntPtr password);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void freeUser(IntPtr head);
    
    //统计
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getStatisticHead();
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int addStatistic(IntPtr head, int room, int seat, long time, IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int deleteStatistic(IntPtr head, int room, int seat, long time);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr returnAllStatistics(IntPtr head, IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void freeStatistics(IntPtr head);
    
    //保存
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int saveSeats(IntPtr head);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int saveUsers(IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int saveStatistics(IntPtr head);
    
    //加载
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int loadSeat(IntPtr head);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int loadUser(IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int loadStatistics(IntPtr head);
    
    //其他
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr login(IntPtr user,IntPtr email,IntPtr password);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int reserveSeat(IntPtr head, int room, int seat, IntPtr user, IntPtr statistic);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int cancelReservation(IntPtr head, int room, int seat, IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr getUserInfo(IntPtr user);
    [DllImport("libLRS.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int test();

}