# CSAudioRecorder
.NET component to record audio from any source to many types of audio files.

![alt CSAudioRecorder](https://www.microncode.com/images/developers/cs-audio-recorder/images/cs-audio-recorder.png "CSAudioRecorder")

# About
The CSAudioRecorder is a .NET component that can record audio from any source to AAC, APE, MP2, MP3, OGG, ACM WAV, PCM WAV and WMA audio files with a specific format, with a built in audio visualization / audio meter controls and a built in ID3 tags editor.

# Benefits
- A Dot NET component.
- Record from any source device.
- To 8+ types of audio formats:
	- AAC - Advanced Audio Coding
	- APE - Monkey's Audio
	- MP2 - MPEG Audio Layer II
	- MP3 - MPEG Audio Layer III
	- OGG - Vorbis Compressed
	- ACM WAV - Audio Compression Manager
	- PCM WAV - Waveform Audio Format
	- WMA - Windows Media Audio
- Low level recorder (LineIn Recorder).
- WASAPI Recorder.
- Record what you hear (WASAPI Loopback).
- Set the recording format:
	- 48Khz to 8Khz sample rates.
	- 8, 16, 24 and 32 bits depth.
	- Mono or stereo.
- Unlimited recording time and length.
- Silence detection.
- Start to record when noise is detected.
- Stop to record when silence is detected.
- Record / Pause Record / Stop Record.
- Get all the installed input devices.
- Get the default input audio device.
- Get the recorded length on real time.
- Get all recorded file size on real time.
- Embedly audio visualization:
	- Set the color base.
	- Set the color max.
	- Set the interval.
	- Set the number of bars to display.
	- Set the spacing between the bars.
	- Embedly audio meter.
- Built in ID3 editor:
	- Set any ID3 tag of the destination file.
	- Set the title, album, track#, comment, artist etc.
	- Set the ID3 image of the destination file.
- Many relevant events.
- Built in threads handling.
- Safe exit.
- Can be run as a library.
- Easy to use.
- C# / VB .NET well documented examples.
- Cut your developing time up to 80%.
- Just drop the component controls in your form and start to work immediately.
- The source code of this component is also available.
- Licensed under the MS-PL.
- Can be used in commercial products.

# FREE Usage
This component can be use for FREE for personal or free usage. Just add the following details to the username and the regkey in the form_load event:

```
audioRecorder1.UserName = "Free@Usage";
audioRecorder1.UserKey = "965565d0eb821b64874a4d01e91a86a8";
```

# Commercial usage

![alt License](http://www.microncode.com/images/medal128.png "License")

For commercial or any other usage please buy a license to get your own username and regkey (one time fee of 89$) at:

[Buy CSAudioRecorder Commercial License](https://order.shareit.com/cart/add?vendorid=200277377&PRODUCT[300914539]=1)

* The source code of this component is also available.

# License
- The examples and the component are licensed under MS-PL. 
- Some external libraries / plugin may lincesed under LGPL.

# Credits
This component uses some external libraries / plugins in the background:
- [CSCore](https://github.com/filoe/cscore)
- [TagLib#](https://github.com/mono/taglib-sharp)
- [MACDll.dll](https://www.monkeysaudio.com/index.html)
- [vorbis.dll, ogg.dll and vorbisfile.dll](https://www.monkeysaudio.com/index.html)

Those external libraries / plugins are already included with the examples.
