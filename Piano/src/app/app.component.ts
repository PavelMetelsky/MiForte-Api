import { Component, ViewEncapsulation } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { filter } from 'rxjs/operators';
import { BuildCheckerService } from './shared/base/build-checker.service';
import { StateParamsService } from './shared/base/state-params.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class AppComponent {
  constructor(
    router: Router,
    stateParams: StateParamsService,
    buildChecker: BuildCheckerService
  ) {
    router.events
      .pipe(filter((e) => e instanceof NavigationEnd))
      .subscribe((event: NavigationEnd) => {
        if (event.urlAfterRedirects) {
          //AppComponent.pageViewAnalyticsEvent(event.urlAfterRedirects);
          if (buildChecker.needsReload) {
            window.location.reload();
          }
        }
        stateParams.onUrlChanged();
      });
  }

  private static pageViewAnalyticsEvent(url: string): void {
    // eslint-disable-next-line @typescript-eslint/camelcase
    gtag('event', 'page_view', { page_path: url });
  }
}
