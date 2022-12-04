import { HttpClient } from '@angular/common/http';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-search-post',
  templateUrl: './search-post.component.html',
  styleUrls: ['./search-post.component.css']
})
export class SearchPostComponent implements OnInit {
  post: any = {}
  id;
  
  constructor(
    private http: HttpClient,
    private route: Router) {}

  ngOnInit(): void {

  }


  cancel() {
    this.home();
  }

  home() {
    this.route.navigate(["/"]);
  }



  getPost(){
    //let id = '01be19f3-dd53-43c7-9b50-1bf0c4fb5dfa';
    let id = this.post.id;
    this.route.navigate(["/posts/"+ id]);
  }

}
