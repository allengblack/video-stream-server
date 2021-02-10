const videoTag = document.getElementById('videoPlayer');

const myMediaSource = new MediaSource();

const videoSrcBuffer = myMediaSource.addSourceBuffer(
  "video/mp4; codecs='avc1.64001e'"
);

fetch('http://localhost:5001/api/stream')
  .then((res) => {
    return res.arrayBuffer();
  })
  .then((videoData) => {
    videoSrcBuffer.appendBuffer(videoData);
  });

const url = URL.createObjectURL(myMediaSource);

videoTag.src = url;
