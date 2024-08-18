ffmpeg -i "video_url" -vf "ass=subtitle.ass" -c:v h264_nvenc -preset p1 -b:v 2M -c:a aac -b:a 192k -s 1280x720 "./video.mp4"

Explanation of the Command:
-i "video_url": Specifies the input video URL.
-vf "ass=subtitle.ass": Adds the subtitles from the .ass file.
-c:v h264_nvenc: Uses NVIDIA's H.264 encoder.
-preset p1: Sets the encoding preset for h264_nvenc. You can adjust the preset based on your performance and quality needs (p1 is a good balance between quality and speed).
-b:v 2M: Sets the video bitrate to 2 Mbps.
-c:a aac: Uses the AAC codec for audio.
-b:a 192k: Sets the audio bitrate to 192 kbps.
-s 1280x720: Sets the output resolution to 1280x720.
output.mp4: Specifies the output file name.






ffmpeg -i "https://example.com/example.vtt" ./example.ass"
ffmpeg -i "https://example.com/example.m3u8" -vf "ass=./example.ass" -c:v h264_nvenc -preset p1 -b:a 192k "./video.mp4"
