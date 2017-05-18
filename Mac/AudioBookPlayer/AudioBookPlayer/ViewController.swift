//
//  ViewController.swift
//  AudioBookPlayer
//
//  Created by Vishwenga on 2017-04-30.
//  Copyright © 2017 Vishwa. All rights reserved.
//

import AVFoundation
import Cocoa

class ViewController: NSViewController,NSWindowDelegate{
    
    var theUrl = "" //enter the server url here
    @IBOutlet weak var comboBox: NSComboBox!
    @IBOutlet weak var label2: NSTextField!
    @IBOutlet weak var seeker: NSSlider!
    var safeUpdate = false
    var currentLoc = 5858585.0
    var audioPlayer = AVAudioPlayer()
    @IBOutlet weak var label1: NSTextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        //keep play time UI updated, timer1
        _ = Timer.scheduledTimer(timeInterval: 1, target: self, selector: #selector(self.update), userInfo: nil, repeats: true);
    }

    override var representedObject: Any? {
        didSet {}
    }
    
    @IBAction func seekRightLeft(_ sender: Any) {
        audioPlayer.currentTime = TimeInterval(seeker.intValue)
    }
    
    //show select file diaglog
    @IBAction func browseFile(sender: AnyObject) {
        let dialog = NSOpenPanel();
        dialog.title                   = "Choose a Audiobook file";
        dialog.showsResizeIndicator    = true;
        dialog.showsHiddenFiles        = false;
        dialog.canChooseDirectories    = true;
        dialog.canCreateDirectories    = true;
        dialog.allowsMultipleSelection = false;
        dialog.allowedFileTypes        = ["mp3","m4b"];
        
        if (dialog.runModal() == NSModalResponseOK) {
            let result = dialog.url
            if (result != nil) {
                let path = result!.path
                let wtf = path.components(separatedBy: "/")[path.components(separatedBy: "/").count-1]
                label1.stringValue = wtf
                setupPlayer(soundName: path)
            }
        } else {
            return
        }
    }
    
    //setup player
    func setupPlayer(soundName: String)
    {
        let coinSound =  Bundle.main.url(forAuxiliaryExecutable: soundName)!
        do{
            audioPlayer = try AVAudioPlayer(contentsOf:coinSound)
            audioPlayer.prepareToPlay()
            audioPlayer.volume = 1
            safeUpdate = true
            seeker.maxValue = audioPlayer.duration
        }catch {
            print("Error getting the audio file")
        }
    }
    
    //stop button
    @IBAction func stopAudio(_ sender: NSButton) {
        audioPlayer.stop()
    }
    
    //play button
    @IBAction func playAudio(_ sender: NSButton) {
        audioPlayer.play()
    }
    
    //pause button
    @IBAction func pauseAudio(_ sender: NSButton) {
        audioPlayer.pause()
    }
    
    //get bookmark saved on server
    @IBAction func getSave(_ sender: NSButton) {
        let myURLString = theUrl + "/data.txt"
        guard let myURL = URL(string: myURLString) else {
            print("Error: \(myURLString) doesn't seem to be a valid URL")
            return
        }
        
        do {
            let myHTMLString = try String(contentsOf: myURL, encoding: .ascii)
            let intStamp = Double(myHTMLString as String)
            currentLoc = intStamp!
            audioPlayer.currentTime = currentLoc
        } catch let error {
            print("Error: \(error)")
        }    }

    //set cuurent bookmark to server
    @IBAction func setSave(_ sender: NSButton) {
        currentLoc = audioPlayer.currentTime
        let setupURL = theUrl + "/post.php?w=" + String(currentLoc)
        let url = URL(string: setupURL)
        
        let task = URLSession.shared.dataTask(with: url!) {(data, response, error) in
            print(NSString(data: data!, encoding: String.Encoding.utf8.rawValue)!)
        }
        task.resume()
    }
    
    //set sleep timer
    @IBAction func comboBox(_ sender: NSComboBoxCell) {
        switch (comboBox.indexOfSelectedItem){
        case 0:
        _ = Timer.scheduledTimer(timeInterval: 1800, target: self, selector: #selector(self.sleepTime), userInfo: nil, repeats: true);
            break
        case 1:
            _ = Timer.scheduledTimer(timeInterval: 3600, target: self, selector: #selector(self.sleepTime), userInfo: nil, repeats: true);
            break
        case 2:
            _ = Timer.scheduledTimer(timeInterval: 7200, target: self, selector: #selector(self.sleepTime), userInfo: nil, repeats: true);
            break
        default: break
        }
    }
    
    //sleep timer
    func sleepTime() {
        let task = Process()
        task.launchPath = "/usr/bin/pmset"
        task.arguments = ["sleepnow"]
        task.launch()
        exit(0)
    }
    
    //timer1 update
    func update(){
        if (safeUpdate){
            seeker.intValue = Int32(audioPlayer.currentTime)
            label2.stringValue = String(String(format: "%.2f",(audioPlayer.currentTime)/60)) + "/" + String(String(format: "%.2f",(audioPlayer.duration)/60)) + " mins"
        }
    }
    
    //exit on close functions
    override func viewDidAppear() {
        self.view.window?.delegate = self
    }
    func windowShouldClose(_ sender: Any) {
        NSApplication.shared().terminate(self)
    }
}

