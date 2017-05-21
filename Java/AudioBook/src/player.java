import java.awt.FileDialog;
import java.io.BufferedReader;
import java.io.File;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.ProtocolException;
import java.net.URL;

import javax.swing.JFrame;
import javax.swing.JLabel;

import javafx.embed.swing.JFXPanel;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;

public class Player {
	private final JFXPanel fxPanel = new JFXPanel();
	private static final String URL = "";
	private static String selectedFile = "";
	private static double currentLoc = 0;
	private Media hit;
	private MediaPlayer mediaPlayer;	
	
	private void initPlayer(){
		String bip = selectedFile;
		System.out.println(bip.replace("\\","/"));
		hit = new Media(new File(bip).toURI().toString());
		mediaPlayer = new MediaPlayer(hit);		
	}
	
	protected void play(){
		mediaPlayer.play();
	}
	protected void stop(){
		mediaPlayer.stop();
	}
	protected void pause(){
		mediaPlayer.pause();
	}
	
	protected void openFileDialog(JFrame hwn, JLabel label){
		FileDialog fd = new FileDialog(hwn, "Choose a file", FileDialog.LOAD);
		fd.setDirectory("C:\\");
		fd.setFile("*.*");
		fd.setVisible(true);
		String fileName = fd.getFile();
		if (fileName != null)
		selectedFile = fd.getDirectory() + fileName;	
		label.setText(fileName);
		initPlayer();
	}
	
	protected void uploadToSever() throws Exception{
		String url = URL + "/post.php?w=" + currentLoc;
		
		URL obj = new URL(url);
		HttpURLConnection con = (HttpURLConnection) obj.openConnection();

		con.setRequestMethod("GET");

		con.setRequestProperty("User-Agent", "Mozilla/5.0");
		int responseCode = con.getResponseCode();	
	}
	
	protected void downloadFromServer() throws Exception{
		String url = URL +  "/data.txt";

		URL obj = new URL(url);
		HttpURLConnection con = (HttpURLConnection) obj.openConnection();

		con.setRequestMethod("GET");

		con.setRequestProperty("User-Agent", "Mozilla/5.0");

		int responseCode = con.getResponseCode();

		BufferedReader in = new BufferedReader(
		        new InputStreamReader(con.getInputStream()));
		String inputLine;
		StringBuffer response = new StringBuffer();

		while ((inputLine = in.readLine()) != null) {
			response.append(inputLine);
		}
		in.close();

		currentLoc = Double.parseDouble(response.toString());
	}
	
}
