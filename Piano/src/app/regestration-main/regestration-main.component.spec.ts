import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { RegestrationMainComponent } from './regestration-main.component';

describe('RegestrationMainComponent', () => {
  let component: RegestrationMainComponent;
  let fixture: ComponentFixture<RegestrationMainComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ RegestrationMainComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegestrationMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
