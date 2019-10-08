import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DepinfoComponent } from './depinfo.component';

describe('DepinfoComponent', () => {
  let component: DepinfoComponent;
  let fixture: ComponentFixture<DepinfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DepinfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DepinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
