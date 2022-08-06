import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { RegestrationFinalComponent } from './regestration-final.component';

describe('RegestrationFinalComponent', () => {
  let component: RegestrationFinalComponent;
  let fixture: ComponentFixture<RegestrationFinalComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ RegestrationFinalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegestrationFinalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
