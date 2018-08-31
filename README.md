# Smart-Audio-Book-Player
Allows you to listen to audio books, it automatically saves your progress and remebers the book last played. It also can shut down your pc after certain amount of time, or close it self.
Also allows you to upload the saved location to a server so your last saved location is accessible on any device you decide to listen to the audiobook (Synced over the web). 

ALSO can be controlled by Phone (only windows and Java port).

# Ports 

Windows:

[![Video](http://i.imgur.com/KmCVlnU.png)](https://www.youtube.com/watch?v=w3NEF69L3js)

----------------------------

Mac:

![Mac Port](http://i.imgur.com/QNuGnTa.png)


------------------------------


Linux (Java):

![Java](http://i.imgur.com/XWq4D4Q.png)


# Set up online

Recommend localhost, but if your looking for a online service, i recommend/used/tested on : https://en.altervista.org/

Upload the server files to the filemanager. And update `index.js` according to your domain and update `Form1.vb` code to:

``Dim onlineEnabled = True``

``Dim phpFileURL As String = "YOUR URL HERE" 'example : http://exmaple.com/AudioBookSync/post.php``



------------------------------


# Remort Control

To enable remote control update code to ``Dim remoteControl = True`` on windows.

This only works with Windows and Java port so far.

![remote](https://imgur.com/7rlCXUe.jpg?)

Look up the `index.html` hosted on your server on your phone and it should work right away. :)


# Download 

https://github.com/vishwenga/Smart-Audio-Book-Player/releases
