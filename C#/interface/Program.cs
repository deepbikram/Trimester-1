//"CAN DO" Concept
interface IPlayable { void Play(); }
interface IPausable { void Pause(); }

class MusicPlayer : IPlayable, IPausable
{
    public void Play() { Console.WriteLine("Play"); }
    public void Pause() { Console.WriteLine("Paused"); }
}

class Program
{
    static void Main()
    {
        MusicPlayer player = new MusicPlayer();
        player.Play();
        player.Pause();
    }
}

//A music player IS a device (abstract class - one parent)
//A music player CAN play, pause, stop, next, previous (interfaces - many abilities)