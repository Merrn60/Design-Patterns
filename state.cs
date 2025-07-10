using System;

namespace MusicPlayerApp
{
    // Context class: MusicPlayer
    public class MusicPlayer
    {
        private IPlayerState _currentState;

        public MusicPlayer()
        {
            // Initial state is Stopped
            _currentState = new StoppedState();
        }

        public void SetState(IPlayerState newState)
        {
            _currentState = newState;
        }

        public void Play()
        {
            _currentState.Play(this);
        }

        public void Pause()
        {
            _currentState.Pause(this);
        }

        public void Stop()
        {
            _currentState.Stop(this);
        }
    }

    // State interface: IPlayerState
    public interface IPlayerState
    {
        void Play(MusicPlayer player);
        void Pause(MusicPlayer player);
        void Stop(MusicPlayer player);
    }

    // Concrete State: StoppedState
    public class StoppedState : IPlayerState
    {
        public void Play(MusicPlayer player)
        {
            Console.WriteLine("Starting playback.");
            player.SetState(new PlayingState());
        }

        public void Pause(MusicPlayer player)
        {
            Console.WriteLine("Cannot pause. Music is already stopped.");
        }

        public void Stop(MusicPlayer player)
        {
            Console.WriteLine("Music is already stopped.");
        }
    }

    // Concrete State: PlayingState
    public class PlayingState : IPlayerState
    {
        public void Play(MusicPlayer player)
        {
            Console.WriteLine("Music is already playing.");
        }

        public void Pause(MusicPlayer player)
        {
            Console.WriteLine("Pausing playback.");
            player.SetState(new PausedState());
        }

        public void Stop(MusicPlayer player)
        {
            Console.WriteLine("Stopping playback.");
            player.SetState(new StoppedState());
        }
    }

    // Concrete State: PausedState
    public class PausedState : IPlayerState
    {
        public void Play(MusicPlayer player)
        {
            Console.WriteLine("Resuming playback.");
            player.SetState(new PlayingState());
        }

        public void Pause(MusicPlayer player)
        {
            Console.WriteLine("Music is already paused.");
        }

        public void Stop(MusicPlayer player)
        {
            Console.WriteLine("Stopping playback.");
            player.SetState(new StoppedState());
        }
    }

    // Main method to test the functionality
    class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();

            Console.WriteLine("Initial State: Stopped");
            player.Play(); // Transition to Playing
            player.Pause(); // Transition to Paused
            player.Play(); // Transition to Playing
            player.Stop(); // Transition to Stopped
            player.Pause(); // Invalid action in Stopped
        }
    }
}
