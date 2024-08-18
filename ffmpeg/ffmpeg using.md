```
ffmpeg -i "https://gg3.biananset.net/_v7/73850d3a2ef1e0ed7c38f43c0e7c4ea89f8decc4daf73b2700bd4a1f9f04f1d0c6ccb082c5fdd27cf98b39da186100165432a5a4b2c628401923e3eee0414e516515cd8cf4ef0e46a95390cf08ee4d672ef2a25cd177b1f2ec3a574adcd8911d5b0fdd638fd9cfeb1184692bfe4ef98c907227adc9eb5a47e390d87655bc2659/master.m3u8" -vf "ass=subtitle.ass" -c:v h264_nvenc -preset p1 -b:v 2M -c:a aac -b:a 192k -s 1280x720 "./video.mp4"
```

```
ffmpeg -i "https://gg3.biananset.net/_v7/73850d3a2ef1e0ed7c38f43c0e7c4ea89f8decc4daf73b2700bd4a1f9f04f1d0c6ccb082c5fdd27cf98b39da186100165432a5a4b2c628401923e3eee0414e516515cd8cf4ef0e46a95390cf08ee4d672ef2a25cd177b1f2ec3a574adcd8911d5b0fdd638fd9cfeb1184692bfe4ef98c907227adc9eb5a47e390d87655bc2659/master.m3u8" -vf "ass=subtitle.ass" -c:v h264_nvenc -preset p1 -b:a 192k "./video.mp4"
```






```
ffmpeg -i "https://ccb.megaresources.co/e3/35/e3357bc9764d7a0f1bdf4dc1e7eb0176/eng-2.vtt" "./test.ass"
```

```
ffmpeg -i "https://gg3.biananset.net/_v7/73850d3a2ef1e0ed7c38f43c0e7c4ea89f8decc4daf73b2700bd4a1f9f04f1d0c6ccb082c5fdd27cf98b39da186100165432a5a4b2c628401923e3eee0414e516515cd8cf4ef0e46a95390cf08ee4d672ef2a25cd177b1f2ec3a574adcd8911d5b0fdd638fd9cfeb1184692bfe4ef98c907227adc9eb5a47e390d87655bc2659/master.m3u8" -vf "ass=./test.ass" -c:v h264_nvenc -preset p1 -b:a 192k "./video.mp4"
```
