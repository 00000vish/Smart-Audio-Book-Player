import java.awt.FileDialog;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.ProtocolException;
import java.net.Socket;
import java.net.URL;
import java.net.UnknownHostException;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JSlider;

import javafx.embed.swing.JFXPanel;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;
import javafx.util.Duration;
import java.util.Timer;
import java.util.TimerTask;

public class AbPlayer {
	private final JFXPanel fxPanel = new JFXPanel();
	private String selectedFile = "";
	private double currentLoc = 0;
	private Media hit;
	private MediaPlayer mediaPlayer;
	private JSlider slider;
	private JLabel timeLabel;
	private boolean ign = false;
	private boolean onlineEnabled = true;
	Socket clientSocket = null;

	private void initPlayer() throws Exception{
		connectToServer();
		if(mediaPlayer != null)
			mediaPlayer.dispose();
		String bip = selectedFile;
		hit = new Media(new File(bip).toURI().toString());
		mediaPlayer = new MediaPlayer(hit);
		timeLabel.setText("Ready");
		
		
		Timer timer = new Timer();	
		timer.scheduleAtFixedRate(new TimerTask() {
			  @Override
			  public void run() {
				  ign = true;
				  slider.setValue((int) mediaPlayer.getCurrentTime().toSeconds());
				  ign = false;
				  timeLabel.setText(mediaPlayer.getCurrentTime().toMinutes() + "/" + String.valueOf(mediaPlayer.getTotalDuration().toMinutes()));				  
				  try {
					String res = talkToServer("null");
					switch(res) {
					case "play" : play();break;
					case "pause" : pause();break;
					case "save" : uploadToSever();break;
					//rest is todo
					}
				} catch (Exception e) {					
					e.printStackTrace();
				}
			  }
			}, 2*1000, 2*1000);
	}

	protected void play(){
		slider.setMaximum((int)mediaPlayer.getTotalDuration().toSeconds());
		//timeLabel.setText("0.00/" + String.valueOf(mediaPlayer.getTotalDuration().toMinutes()));		
		mediaPlayer.play();

	}
	protected void stop(){
		mediaPlayer.stop();
	}
	protected void pause(){		
		mediaPlayer.pause();
	}

	protected void openFileDialog(JFrame hwn, JLabel label, JSlider slder, JLabel time) throws Exception{
		FileDialog fd = new FileDialog(hwn, "Choose a file", FileDialog.LOAD);
		fd.setDirectory("C:\\");
		fd.setFile("*.*");
		fd.setVisible(true);
		String fileName = fd.getFile();
		if (fileName != null)
		selectedFile = fd.getDirectory() + fileName;
		label.setText(fileName);
		slider = slder;
		timeLabel = time;
		initPlayer();
	}
	
	private void connectToServer() throws Exception {
		try {
			clientSocket = new Socket("localhost", 7331);			
		}catch(Exception e) {
			onlineEnabled = false;
		}		 
	}
	
	private String talkToServer(String data) throws Exception {
		 if(onlineEnabled) {
			  Socket clientSocket = new Socket("localhost", 7331);		//hmmm idk
			  DataOutputStream outToServer = new DataOutputStream(clientSocket.getOutputStream());
			  outToServer.writeBytes(data);			  
			  byte[] messageByte = new byte[1000];			 
			  String dataString = "";
			  DataInputStream in = new DataInputStream(clientSocket.getInputStream());		    
			  int bytesRead = in.read(messageByte);
			  dataString += new String(messageByte, 0, bytesRead);
			  return dataString;
		 }else {
			 return "null";
		 }		
	}

	protected void uploadToSever() throws Exception{
		currentLoc = mediaPlayer.getCurrentTime().toSeconds();
		talkToServer("save-" + currentLoc);
	}

	protected void jumpTo(int loc){
		try{		
			if(!ign)
			mediaPlayer.seek(new Duration(loc*1000));
		}catch(Exception e){}
	}

	protected void downloadFromServer() throws Exception{		
		currentLoc = Double.parseDouble(talkToServer("get"));
		mediaPlayer.seek(new Duration(currentLoc));
		slider.setValue((int) currentLoc);
	}

}
