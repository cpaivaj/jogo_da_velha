/*
 *	AudioPlayer.cs
 *	Author: Lucas Cota
 *  Description: Audio Streamer.
 *	Date: 2018-05-16
 *	Modified: 2018-05-16
 */

using System;
using System.IO;
using NAudio.Wave;
using jogo_da_velha.Interfaces;
using System.Collections.Generic;

namespace jogo_da_velha.Helpers
{
	class AudioPlayer
	{
		// Resources
		private WaveStream waveStream;
		private IWavePlayer audioPlayer;
		private List<string> audioPlaylist;
		private IOnAudioChange onAudioChange;


		// Checkers
		private int playlistPosition = -1;
		private bool playlistManualState = false;





		// Playlist Constructor
		public AudioPlayer(IOnAudioChange onAudioChange, List<string> audioPlaylist)
		{
			this.onAudioChange = onAudioChange;
			this.audioPlaylist = new List<string>(audioPlaylist);
		}




		public bool Stream()
		{
			if (waveStream != null)
			{
				waveStream.Dispose();
			}

			if (audioPlayer != null)
			{
				audioPlayer.Dispose();
			}

			if (audioPlaylist.Count < 1)
			{
				return false;
			}

			audioPlayer = new WaveOutEvent();

			if (!playlistManualState)
			{
				playlistPosition++;
				waveStream = new AudioFileReader(audioPlaylist[playlistPosition]);
			}
			else
			{
				playlistManualState = false;
				waveStream = new AudioFileReader(audioPlaylist[playlistPosition]);
			}

			audioPlayer.Init(waveStream);
			audioPlayer.PlaybackStopped += (sender, evn) => { Stream(); };
			audioPlayer.Play();

			onAudioChange.AudioChanged();

			return true;
		}

		public void Play()
		{
			if (audioPlayer != null)
			{
				audioPlayer.Play();
			}
		}

		public void Pause()
		{
			if (audioPlayer != null)
			{
				audioPlayer.Pause();
			}
		}

		public void SetVolume(int volume)
		{
			if (audioPlayer != null)
			{
				audioPlayer.Volume = volume / 100f;
			}
		}

		public void SetTime(int time)
		{
			if (audioPlayer != null)
			{
				waveStream.CurrentTime = TimeSpan.FromSeconds((waveStream.TotalTime.TotalSeconds * time) / 100);
			}
		}

		public void Next()
		{
			if (audioPlayer != null)
			{
				if (playlistPosition != audioPlaylist.Count - 1)
				{
					playlistPosition++;
				}
				else
				{
					playlistPosition = 0;
				}

				audioPlayer.Stop();

				playlistManualState = true;
			}
		}

		public void Back()
		{
			if (audioPlayer != null)
			{
				if (playlistPosition != 0)
				{
					playlistPosition--;
				}
				else
				{
					playlistPosition = audioPlaylist.Count - 1;
				}

				audioPlayer.Stop();

				playlistManualState = true;
			}
		}

		public string GetAudioName()
		{
			if (audioPlayer != null)
			{
				return Path.GetFileNameWithoutExtension(audioPlaylist[playlistPosition]);
			}

			return null;
		}

		public TimeSpan GetAudioTime()
		{
			if (audioPlayer != null)
			{
				// ToString("mm\\:ss");
				return waveStream.TotalTime;
			}

			return TimeSpan.Zero;
		}

		public TimeSpan GetAudioCurrentTime()
		{
			if (audioPlayer != null)
			{
				// ToString("mm\\:ss");
				return waveStream.CurrentTime;
			}

			return TimeSpan.Zero;
		}
	}
}
